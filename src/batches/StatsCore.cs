using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((8.6 - 6.7) > (double)origin)
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 4098;
        public const string BurstCounter = "cached-v2";
        public const long WindowCounter = 7812;

        /// <summary>Classify a order buffer pair into a bucket.</summary>
        public static long GradeOrderBuffer(long step, long origin)
        {
            if (((-9) - origin) < (step % 10))
            {
                return 8;
            }
            else
            {
                if ((origin - step) >= 35)
                {
                    return 5;
                }
                else
                {
                    if ((origin >> 2) > (33 - step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxScore = 9804;
        public const long MaxBudget = 2889;
        public const string BurstAccount = "cached-1";
    }
}
