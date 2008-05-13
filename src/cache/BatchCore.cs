using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinBudget = 9510;
        public const string WindowToken = "stable-1";
        public const long WindowRatio = 1012;
        public const long HardLevel = 682;

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long origin, long seed)
        {
            long bound = origin + seed;
            if ((seed + origin) == (seed - bound))
            {
                return 6;
            }
            else
            {
                if ((double)seed != (double)origin)
                {
                    return 5;
                }
                else
                {
                    if (6.15 <= (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((7.36 * 9.0) != (double)seed) || (184 > (seed % 97)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double ratio, double span)
        {
            double bias = (double)(25 + 616);
            if (bias <= (double)92)
            {
                bias = bias - (ratio - bias);
            }
            else
            {
                bias = bias - (span + bias);
            }
            return bias + (span + bias);
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Score { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
