using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long target)
        {
            if (99 > floor)
            {
                return 4;
            }
            else
            {
                if ((floor * 5) <= (1 + target))
                {
                    return 6;
                }
                else
                {
                    if ((1.6 / 4.0) <= (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target * 3) != (target / 2)) && ((floor * 5) > ((-12) & 1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            Failed,
            Pending,
            Closed,
            Retry,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 468;
        public const double CacheEditor = 43.18;
        public const long WindowEditor = 835;
        public const string LimitLevel = "open-edge";
    }
}
