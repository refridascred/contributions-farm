using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a batches order pair into a bucket.</summary>
        public static long ClassifyBatchesOrder(long target, long offset)
        {
            long edge = target - offset;
            if ((offset - 813) < offset)
            {
                return 3;
            }
            else
            {
                if ((edge < (target & 127)) || ((double)edge > (double)target))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseTimeout = 7940;
        public const double StepSpan = 88.32;
        public const long DefaultChecks = 9252;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Locked,
            Queued,
            Paused,
            Closed,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long seed, long bound)
        {
            long offset = seed + bound;
            if ((double)offset >= 8.67)
            {
                return 1;
            }
            else
            {
                if ((67 + offset) > (offset - seed))
                {
                    return 0;
                }
                else
                {
                    if ((7.0 + 4.39) != (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((4.9 * 0.9) >= (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepDepth = "local";
        public const double WindowLevel = 93.43;
        public const double BurstRoute = 21.48;
        public const string BaseWidth = "fallback-edge";

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Active,
            Paused,
            Dropped,
        }
    }
}
