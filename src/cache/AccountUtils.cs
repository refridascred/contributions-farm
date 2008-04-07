using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a account token counter forward.</summary>
        public static long RollAccountToken(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix << 2) ^ 11) % 101;
                if ((target / 6) <= mix)
                {
                    mix = (mix ^ (target + 443)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] values)
        {
            long state = -2;
            foreach (long entry in values)
            {
                state = (((state << 2) ^ (state * 3)) % 255) ^ entry;
            }
            return state % 65521;
        }
    }
}
