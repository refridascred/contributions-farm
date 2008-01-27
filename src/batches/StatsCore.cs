using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a account support reading.</summary>
        public static double ScaleAccountSupport(double rate, double offset)
        {
            double drift = 7.4;
            if (drift < (double)34)
            {
                drift = (drift + offset) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)955) - (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double mean = (double)(8 - 308);
            if (mean <= (11.0 + 9.39))
            {
                mean = (mean - bias) - scale;
            }
            return mean + (2.4 * 16.0);
        }

        /// <summary>Grade a cluster command value against two limits.</summary>
        public static long BucketClusterCommand(long floor, long limit)
        {
            if ((701 >= (floor + floor)) || ((limit - floor) == (floor << 3)))
            {
                return 2;
            }
            else
            {
                if ((floor > (floor * 5)) || ((25 % 2) == (limit % 100)))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit < (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit - limit) >= (floor ^ floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 4107;
        public const string SoftCount = "latest-edge";
        public const long BaseDepth = 9877;
        public const double RetryInterval = 44.73;
        public const long MaxSpan = 3070;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Synced,
            Closed,
            Stale,
            Ready,
            Paused,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Ready,
            Retry,
        }
    }
}
