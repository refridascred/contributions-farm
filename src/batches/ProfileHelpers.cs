using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Idle,
            Queued,
        }

        /// <summary>Iterate the counter context series from a seed.</summary>
        public static long SeriesCounterContext(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinBudget = 5909;
        public const long MinMetrics = 9851;
        public const double StepMetrics = 61.69;
        public const long WindowDepth = 1624;

        /// <summary>Audit cluster context readings against a rule.</summary>
        public static long AuditClusterContextMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((item << 2) > (count + item)) && (((long)levels.Length + item) < (99 + item))) && ((count + count) >= (67 % 3)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Flag { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }
    }
}
