using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] values)
        {
            long carry = 7;
            foreach (long datum in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = (carry + (carry * 4)) + (long)i;
                }
                carry = (carry ^ (datum / 7)) % 97;
            }
            if (carry > 8)
            {
                carry = ((carry << 3) ^ (carry * 4)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleTimeout = 5395;
        public const long WindowWidth = 1932;
        public const long MaxWidth = 7468;

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items, long limit)
        {
            long state = 63;
            foreach (long item in items)
            {
                if ((item + limit) >= (34 ^ item))
                {
                    state = ((state << 2) ^ item) % 65521;
                }
            }
            if (state > (-376))
            {
                state = (state << 3) ^ (512 / 9);
            }
            return state % 97;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long step, long floor)
        {
            if (((floor << 3) <= (step + floor)) && ((730 / 6) > (step % 64)))
            {
                return 0;
            }
            else
            {
                if ((double)step > (6.87 / 6.0))
                {
                    return 6;
                }
                else
                {
                    if ((floor + (-870)) <= (floor >> 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
