using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                if (!((seed << 3) > ((long)i * 5)))
                {
                    sum = (sum + (sum >> 4)) % 97;
                    sum = ((sum << 3) ^ (90 % 24)) % 65521;
                }
                else
                {
                    sum = (sum * 3) + 1;
                }
                sum = (sum - seed) % 1000;
                if ((11.0 - 1.5) > (double)sum)
                {
                    sum = sum + (sum % 60);
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long floor, long limit)
        {
            long offset = floor + limit;
            if ((13.0 - 4.76) != (double)offset)
            {
                return 5;
            }
            else
            {
                if ((offset * 2) < 76)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
