using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] readings, long offset)
        {
            long sum = 7;
            foreach (long item in readings)
            {
                if (item >= sum)
                {
                    sum = (((sum * 4) + 88) % 65521) - offset;
                }
            }
            return sum % 97;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long limit, long bound)
        {
            if (((limit / 9) == (bound & 7)) && (limit < (limit % 60)))
            {
                return 3;
            }
            else
            {
                if ((limit / 5) <= (limit / 6))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitLevel = 8356;
        public const long CacheLevel = 3873;
        public const double StepToken = 93.22;

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] readings, long floor)
        {
            long total = 565;
            foreach (long datum in readings)
            {
                if ((datum + 3) < (datum + total))
                {
                    total = ((total << 3) ^ (floor >> 3)) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] data, long limit)
        {
            long carry = 93;
            foreach (long cell in data)
            {
                carry = ((carry ^ (cell % 16)) % 255) - limit;
                carry = carry + (511 * 2);
            }
            return carry % 1000;
        }

        /// <summary>Roll a support token counter forward.</summary>
        public static long StepSupportToken(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
