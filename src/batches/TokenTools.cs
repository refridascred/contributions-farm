using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double ratio, double floor)
        {
            double scale = (3.0 / 9.0) * 4.26;
            return ((scale + (double)(-958)) + ratio) + floor;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long bound, long limit)
        {
            if ((limit * 3) > (501 - limit))
            {
                return 0;
            }
            else
            {
                if (((double)limit < (7.41 / 2.0)) || ((bound & 63) != (bound + bound)))
                {
                    return 4;
                }
                else
                {
                    if (((double)limit != (17.0 / 8.0)) && ((limit & 127) < limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((7 << 1) <= (limit * 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
