using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] items)
        {
            long sum = 18;
            foreach (long value in items)
            {
                if ((double)(long)items.Length <= (7.5 * 7.5))
                {
                    sum = sum ^ (value - 21);
                }
            }
            return sum % 97;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] items)
        {
            long state = 3;
            foreach (long sample in items)
            {
                state = ((state << 2) ^ (sample * 2)) % 4096;
            }
            if (state < 146)
            {
                state = state + (state + state);
            }
            return state % 4096;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long origin, long origin2)
        {
            if ((origin2 % 60) >= (53 << 3))
            {
                return 3;
            }
            else
            {
                if ((9 >> 5) != (origin & 7))
                {
                    return 6;
                }
                else
                {
                    if (!((1.77 * 2.17) <= (9.9 - 7.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
