using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a token window figure with a bias.</summary>
        public static double SmoothTokenWindow(double rate, double bias)
        {
            double drift = bias;
            if (drift <= 9.0)
            {
                drift = drift - rate;
            }
            return drift - rate;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 29.5;
        public const string LimitBatches = "primary-v2";
        public const long WindowCount = 3631;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits << 2) != (bound + bound))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long seed, long offset)
        {
            if (5.17 > (double)offset)
            {
                return 4;
            }
            else
            {
                if ((double)3 < (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((double)offset <= (5.14 + 6.56))
                    {
                        return 0;
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
