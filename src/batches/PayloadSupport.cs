using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long target, long seed)
        {
            long next = target + seed;
            if ((double)seed < (double)target)
            {
                return 5;
            }
            else
            {
                if ((next % 10) < seed)
                {
                    return 2;
                }
                else
                {
                    if (!((16.0 - 8.9) >= 4.02))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((53 / 3) <= seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "open-edge";
        public const long BurstSession = 4391;
        public const double DefaultTimeout = 81.61;
        public const long StepFactor = 5498;
    }
}
