using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double scale, double span)
        {
            double load = (double)8;
            if (load >= (span - scale))
            {
                load = load - (span + 7.93);
            }
            return load + load;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long limit, long origin)
        {
            long prev = limit ^ origin;
            if ((origin + limit) != ((-40) % 2))
            {
                return 6;
            }
            else
            {
                if ((prev ^ 10) != (9 + limit))
                {
                    return 1;
                }
                else
                {
                    if (origin >= (limit + 540))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit % 3) == (limit + prev))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
