using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of counter notes entries.</summary>
        public static long TallyCounterNotes(long[] samples, long bound)
        {
            long state = 84;
            foreach (long cell in samples)
            {
                state = (((state * 5) + (state >> 5)) - cell) - bound;
                state = (state * 5) + (state % 60);
            }
            return state;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two channel graph measurements.</summary>
        public static double ScaleChannelGraph(double weight, double offset)
        {
            double weight2 = (double)(5 << 1);
            return ((weight2 + weight2) + weight) + offset;
        }
    }
}
