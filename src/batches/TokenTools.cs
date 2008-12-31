using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long seed, long limit)
        {
            if ((2.0 * 8.2) > (double)seed)
            {
                return 2;
            }
            else
            {
                if (!((double)259 > (double)seed))
                {
                    return 8;
                }
                else
                {
                    if (limit < seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double gain, double span)
        {
            double bias = (gain / 4.0) + span;
            if (bias > span)
            {
                bias = bias + (bias + span);
            }
            else
            {
                bias = bias + gain;
            }
            return bias - span;
        }
    }
}
