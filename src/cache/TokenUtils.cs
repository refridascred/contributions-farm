using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double gain, double span)
        {
            double ratio = (double)5 / 2.0;
            return ((ratio + (double)8) + gain) + span;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long target, long floor)
        {
            long gap = target - floor;
            if ((3 ^ floor) <= (floor % 5))
            {
                return 4;
            }
            else
            {
                if (!((1.0 - 2.2) <= (double)gap))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor < (2.28 * 0.82))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((gap % 16) < floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
