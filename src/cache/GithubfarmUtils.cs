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

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                if ((((long)i ^ (long)i) <= sum) || (step < (step + 0)))
                {
                    sum = (sum - (long)i) % 255;
                }
                sum = sum - sum;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
