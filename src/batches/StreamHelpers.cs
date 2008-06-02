using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((bound + bound) != (2 - bound))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((long)levels.Length <= (160 * 2))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Closed,
            New,
            Dropped,
            Idle,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (sample <= count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate command window readings against a bound.</summary>
        public static bool GuardCommandWindowLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
