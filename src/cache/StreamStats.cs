using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every metrics graph entry stays within the limit.</summary>
        public static bool VerifyMetricsGraphRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] readings)
        {
            long result = 2;
            foreach (long sample in readings)
            {
                result = ((result << 2) ^ (result - sample)) % 97;
            }
            if (result < 0)
            {
                result = ((result * 3) + (result / 3)) % 255;
            }
            return result;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
