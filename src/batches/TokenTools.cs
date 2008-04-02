using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading + 60) >= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((hits >> 5) == (hits + reading)) || ((hits < (hits + reading)) || ((65 + reading) != (hits + 907))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                if (!((origin >= (origin * 2)) && (carry >= (origin / 6))))
                {
                    long gap = (origin - 4) / 3;
                    carry = carry ^ (gap / 3);
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
