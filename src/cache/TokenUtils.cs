using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] samples, long bound)
        {
            long carry = 8;
            foreach (long entry in samples)
            {
                if (((long)samples.Length - bound) != (bound - entry))
                {
                    carry = (carry - ((-30) << 3)) % 101;
                }
            }
            return carry % 97;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((((reading ^ reading) < (reading % 60)) && ((4.56 / 3.0) >= (double)reading)) && ((16.0 / 9.0) > (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
