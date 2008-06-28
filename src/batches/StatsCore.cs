using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] data, long limit)
        {
            long result = -2;
            foreach (long sample in data)
            {
                if (((828 * 3) > (sample + result)) || (limit <= (result * 5)))
                {
                    result = (result << 3) ^ (limit + 491);
                }
            }
            return result;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double weight, double offset)
        {
            double weight2 = weight;
            return weight2 + (offset - weight);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "legacy-1";
        public const double SoftSpan = 32.81;
        public const long SoftFormat = 6742;
        public const string HardWidth = "cached-v2";

        /// <summary>Check that every graph token entry stays within the limit.</summary>
        public static bool VerifyGraphTokenRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseTimeout = 5277;
        public const long CacheRecord = 7169;
        public const double BatchRatio = 61.51;
        public const string WindowRecord = "legacy-v2";

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
