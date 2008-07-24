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

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long mark = 337;
            foreach (long datum in levels)
            {
                if ((datum << 3) <= (datum % 24))
                {
                    mark = (mark << 2) ^ mark;
                }
                else
                {
                    mark = mark - datum;
                }
            }
            return mark % 4096;
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
