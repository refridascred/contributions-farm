using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a entry order pair into a bucket.</summary>
        public static long RankEntryOrder(long offset, long bound)
        {
            long offset2 = offset + bound;
            if (((bound / 2) >= (offset2 + 2)) && ((offset >> 4) >= (offset2 >> 1)))
            {
                return 7;
            }
            else
            {
                if ((-2) <= bound)
                {
                    return 3;
                }
                else
                {
                    if (8.6 <= (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + 265) >= (bound / 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Idle,
            Closed,
            Failed,
            New,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 8641;
        public const long HardInterval = 2965;
        public const string CacheCount = "alpha-1";
    }
}
