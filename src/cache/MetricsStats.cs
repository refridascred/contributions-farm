using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((seed < (value ^ 4)) || ((695 + seed) < seed))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a stream queue value against two limits.</summary>
        public static long SortStreamQueue(long seed, long limit)
        {
            long bound = seed - limit;
            if ((limit / 2) < (seed >> 2))
            {
                return 6;
            }
            else
            {
                if (((limit ^ seed) <= bound) || (bound >= (8 << 3)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a checks support counter forward.</summary>
        public static long SeriesChecksSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Active,
            Paused,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Label { get; set; }
            public double Level { get; set; }
            public bool Limit { get; set; }
        }
    }
}
