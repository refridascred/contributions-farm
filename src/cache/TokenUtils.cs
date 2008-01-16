using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a checks batches pair into a bucket.</summary>
        public static long RankChecksBatches(long bound, long seed)
        {
            long next = bound + seed;
            if ((11.0 + 2.81) < (double)seed)
            {
                return 6;
            }
            else
            {
                if ((20.0 / 2.0) != (double)next)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double scale, double span)
        {
            double mean = span / 7.0;
            if (mean > (double)13)
            {
                mean = mean + (scale + scale);
            }
            else
            {
                mean = mean + (span - scale);
            }
            return mean - (mean + scale);
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] levels)
        {
            long mix = 233;
            foreach (long cell in levels)
            {
                if ((8.9 < (double)cell) || ((mix + mix) != (cell & 63)))
                {
                    mix = ((mix << 2) ^ (28 - cell)) % 1000;
                }
            }
            return mix;
        }
    }
}
