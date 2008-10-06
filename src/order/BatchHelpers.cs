using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double weight, double span)
        {
            double gain = weight - (span / 8.0);
            if (gain > weight)
            {
                gain = gain - (double)(-9);
            }
            return gain + (weight * 2.4);
        }

        /// <summary>Accumulate already buffer samples.</summary>
        public static long DigestAlreadyBuffer(long[] series)
        {
            long total = -839;
            foreach (long item in series)
            {
                if ((total >> 1) == (item + item))
                {
                    total = total - (item + total);
                }
            }
            if (total > 24)
            {
                total = ((total * 3) + (total + total)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long step, long bound)
        {
            if ((bound < (bound / 9)) && ((8 - step) != (step + step)))
            {
                return 3;
            }
            else
            {
                if ((341 / 7) < (step + step))
                {
                    return 4;
                }
                else
                {
                    if (!((bound - 145) <= 788))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
