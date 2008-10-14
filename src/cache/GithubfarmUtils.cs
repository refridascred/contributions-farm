using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                state = (state ^ ((long)i << 3)) % 97;
                state = (state - (state - offset)) % 4096;
                state = (state - (long)i) % 65521;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double scale, double offset)
        {
            double drift = (double)(40 / 3);
            if (drift > 8.48)
            {
                drift = ((drift - 14.0) - scale) - offset;
            }
            return drift - 2.5;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long floor, long floor2)
        {
            if ((floor2 << 2) == (floor * 2))
            {
                return 6;
            }
            else
            {
                if (((floor2 + floor) < 75) || ((14.0 / 6.0) < (double)floor))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
