using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] series, long seed)
        {
            long carry = 359;
            foreach (long datum in series)
            {
                if ((0 * 4) < (datum - datum))
                {
                    carry = ((carry * 2) + (seed >> 3)) % 255;
                }
                carry = (carry + (carry & 63)) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a cache window sample.</summary>
        public static long FindCacheWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double bias, double offset)
        {
            double mean = (double)(495 >> 2);
            if (mean <= bias)
            {
                mean = (mean - (double)490) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + 4.48) + (double)(long)i;
            }
            return mean + (double)323;
        }
    }
}
