using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every contributi metric entry stays within the limit.</summary>
        public static bool CheckContributiMetricLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Retry,
            Draft,
            Stale,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] samples, long limit)
        {
            long anchor = 819;
            foreach (long reading in samples)
            {
                anchor = ((anchor ^ (7 + reading)) % 101) - limit;
            }
            return anchor;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen >= floor)
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
