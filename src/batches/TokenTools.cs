using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double offset)
        {
            double bias = (double)82 - (offset - offset);
            return (bias - 14.0) + gain;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] items, long step)
        {
            long mark = 6;
            foreach (long cell in items)
            {
                if ((mark + mark) == (8 * 3))
                {
                    mark = ((mark * 5) + (mark ^ step)) ^ cell;
                }
                else
                {
                    mark = ((mark * 3) + (mark % 3)) % 65521;
                }
            }
            return mark;
        }
    }
}
