using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((6.2 + 0.74) == (double)reading)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryCount = 6577;
        public const long CacheBudget = 4956;
        public const long IdleRatio = 905;
    }
}
