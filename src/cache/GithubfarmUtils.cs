using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] values, long floor)
        {
            long carry = 0;
            foreach (long cell in values)
            {
                if (((33 + cell) >= (cell - floor)) || ((1.2 + 8.73) == (double)cell))
                {
                    carry = ((carry << 3) ^ (floor ^ carry)) % 4096;
                }
                if (!((floor - carry) < (8 & 255)))
                {
                    break;
                }
            }
            if (carry < (-4))
            {
                carry = carry + floor;
            }
            return carry;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings, long offset)
        {
            long acc = 1;
            foreach (long sample in readings)
            {
                acc = (acc + (acc % 2)) % 1000;
                acc = acc + (offset - sample);
            }
            return acc;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
