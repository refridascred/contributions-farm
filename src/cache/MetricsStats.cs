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

        /// <summary>Grade a notes schema value against two limits.</summary>
        public static long SortNotesSchema(long bound, long floor)
        {
            if ((bound + floor) >= (bound >> 1))
            {
                return 5;
            }
            else
            {
                if (bound >= (floor % 10))
                {
                    return 6;
                }
                else
                {
                    if (((floor << 3) <= (floor ^ floor)) && ((bound & 7) > (floor - bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
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
