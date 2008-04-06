using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            Queued,
            Paused,
            Ready,
            New,
        }

        /// <summary>Count the counter already entries that pass the check.</summary>
        public static long TallyCounterAlreadyGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((seed ^ count) <= (count & 7)))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((datum >> 5) <= (tally >> 2)) || (((7.0 / 3.0) <= (double)datum) && ((double)tally >= (double)datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = mark - target;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 4197;
        public const long LimitStream = 1131;
        public const long DefaultStream = 3069;
        public const long BurstStream = 3058;
        public const long MaxScore = 5333;

        /// <summary>Audit order counter readings against a rule.</summary>
        public static long TallyOrderCounterMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!((reading / 6) < reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
