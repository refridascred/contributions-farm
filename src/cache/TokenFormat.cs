using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two metrics account measurements.</summary>
        public static double ScaleMetricsAccount(double ratio, double offset)
        {
            double weight = offset;
            if (weight >= (weight + 2.99))
            {
                weight = (weight + (double)29) - ratio;
            }
            else
            {
                weight = weight - (0.1 - weight);
            }
            return weight + (double)8;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long floor, long origin)
        {
            long span = floor ^ origin;
            if (((span << 1) > (span - floor)) || ((54 ^ 36) < (origin + span)))
            {
                return 7;
            }
            else
            {
                if ((floor >> 1) > (floor + origin))
                {
                    return 8;
                }
                else
                {
                    if ((span - span) <= span)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((-2) <= (floor >> 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
