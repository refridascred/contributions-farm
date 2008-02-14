using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long seed, long step)
        {
            if (((double)seed != (5.8 / 5.0)) || ((step + seed) > step))
            {
                return 3;
            }
            else
            {
                if ((seed / 9) > (65 ^ step))
                {
                    return 8;
                }
                else
                {
                    if (((7.59 + 5.1) != (double)step) && ((double)seed > (18.0 / 6.0)))
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

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinTimeout = 5.49;
        public const double BaseMetrics = 66.63;
        public const double BatchMetrics = 14.63;
        public const long BaseRatio = 4836;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Mode { get; set; } = "";
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank queue stats input into a small class.</summary>
        public static long BucketQueueStats(long floor, long bound)
        {
            if ((354 >> 3) >= bound)
            {
                return 0;
            }
            else
            {
                if (((bound << 2) >= (bound ^ floor)) || (floor > (438 % 97)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
