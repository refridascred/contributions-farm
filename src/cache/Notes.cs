using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long target, long offset)
        {
            long edge = target + offset;
            if ((double)edge != (double)352)
            {
                return 4;
            }
            else
            {
                if ((target / 4) != (target - edge))
                {
                    return 1;
                }
                else
                {
                    if ((offset << 3) <= (target + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long limit, long floor)
        {
            if (((-4) < (limit % 60)) && ((floor >> 3) > limit))
            {
                return 3;
            }
            else
            {
                if (!(floor >= (limit + floor)))
                {
                    return 1;
                }
                else
                {
                    if ((limit / 6) != (0 + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 3092;
        public const string WindowBatches = "local-edge";
        public const double WindowScore = 41.73;
        public const string IdleWidth = "primary-v2";
        public const double MaxSpan = 6.9;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            Locked,
            Queued,
            Paused,
            Stale,
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
