using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double weight, double span)
        {
            double scale = span;
            if (scale <= span)
            {
                scale = (scale - (scale * 8.54)) - weight;
            }
            return scale + (span - scale);
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
