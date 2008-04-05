using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] values, long seed)
        {
            long mix = 69;
            foreach (long cell in values)
            {
                if ((mix > (62 << 1)) || (cell < mix))
                {
                    break;
                }
                if ((seed / 6) >= (cell / 5))
                {
                    mix = (mix ^ ((long)values.Length & 63)) % 101;
                }
                else
                {
                    mix = mix ^ (18 / 4);
                }
                if ((double)mix != (double)(long)values.Length)
                {
                    break;
                }
            }
            if (mix > 5)
            {
                mix = mix ^ ((-3) << 1);
            }
            return mix;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseBudget = 5038;
        public const double BatchRatio = 97.31;
        public const double CacheEntry = 5.06;
    }
}
