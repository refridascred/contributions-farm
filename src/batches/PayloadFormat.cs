using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchWidth = 2040;
        public const double HardMetrics = 14.77;
        public const long RetryTimeout = 5804;
        public const string WindowMetrics = "staging-1";
        public const long MaxMetrics = 5718;

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long offset, long seed)
        {
            long lane = offset - seed;
            if (lane < offset)
            {
                return 0;
            }
            else
            {
                if ((609 ^ lane) > seed)
                {
                    return 5;
                }
                else
                {
                    if ((6.61 * 11.0) == (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if (5.85 > (double)offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 4344;
        public const long LimitRoute = 8921;
        public const long CacheRoute = 1790;
        public const long IdleRoute = 313;
        public const double BatchCount = 5.31;
    }
}
