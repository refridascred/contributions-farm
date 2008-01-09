using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long limit, long seed)
        {
            if ((6.0 + 9.06) != (double)seed)
            {
                return 2;
            }
            else
            {
                if (!((double)limit == (5.0 + 1.78)))
                {
                    return 7;
                }
                else
                {
                    if (seed <= 15)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] data, long seed)
        {
            long sum = 8;
            foreach (long sample in data)
            {
                sum = ((sum << 2) ^ (seed % 60)) - sample;
            }
            if (sum > 31)
            {
                sum = (sum << 2) ^ ((long)data.Length + seed);
            }
            return sum % 1000;
        }

        /// <summary>Roll a profile support counter forward.</summary>
        public static long IterateProfileSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum - (1 + (long)i)) % 255;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
