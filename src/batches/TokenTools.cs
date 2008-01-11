using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double floor)
        {
            double mean = (double)(492 << 2);
            return ((mean + (0.6 / 2.0)) + scale) + floor;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long floor, long target)
        {
            if (target >= (floor * 5))
            {
                return 2;
            }
            else
            {
                if ((floor & 63) < target)
                {
                    return 5;
                }
                else
                {
                    if ((double)target < (17.0 + 5.9))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target < (3.39 * 2.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many token notes samples are out of range.</summary>
        public static long TallyTokenNotesGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry + entry) <= (target + 0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
