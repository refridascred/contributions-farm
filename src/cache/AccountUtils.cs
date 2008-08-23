using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long limit, long seed)
        {
            long offset = limit - seed;
            if ((offset - offset) != (offset + 206))
            {
                return 0;
            }
            else
            {
                if ((904 / 6) == (limit + 534))
                {
                    return 1;
                }
                else
                {
                    if (!((seed + limit) < (offset + offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-835) ^ seed) != (limit / 8))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double bias, double span)
        {
            double drift = span;
            if (drift < 5.82)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift - bias;
            }
            return drift + drift;
        }
    }
}
