using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 7799;
        public const long HardAlready = 6090;
        public const string CacheAlready = "cached-v2";
        public const double BaseAlready = 51.48;

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] series)
        {
            long score = 52;
            foreach (long sample in series)
            {
                score = ((score + ((-406) << 2)) % 101) ^ sample;
            }
            if (score > 175)
            {
                score = ((score * 3) + (score - score)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Match up metric cluster samples.</summary>
        public static long MatchMetricClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinContext = 19.92;
        public const string BaseSize = "local-edge";
        public const double DefaultTimeout = 52.81;

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
