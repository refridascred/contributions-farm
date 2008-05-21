using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long limit, long offset)
        {
            if ((518 % 60) > limit)
            {
                return 1;
            }
            else
            {
                if (limit < (limit + limit))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) > limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit >= (offset * 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double scale, double span)
        {
            double bias = (double)4 - scale;
            if (bias <= (double)6)
            {
                bias = (bias + (6.36 * 3.28)) + span;
            }
            return bias - (2.37 + scale);
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Stale,
            Failed,
            Draft,
            Dropped,
        }
    }
}
