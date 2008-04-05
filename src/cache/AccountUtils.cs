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

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long origin, long step)
        {
            if ((step % 5) >= 14)
            {
                return 8;
            }
            else
            {
                if (((-198) >> 4) > (origin - step))
                {
                    return 2;
                }
                else
                {
                    if ((step % 100) < (origin - step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin * 2) <= (88 ^ step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
