using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Ready,
            Done,
            Closed,
            Pending,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((double)offset == (8.1 * 1.8)) || ((offset - total) > (offset + 36)))
                {
                    total = (total * 5) + (47 << 2);
                }
                else
                {
                    total = total + ((long)i + total);
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long target, long offset)
        {
            long span = target - offset;
            if (((double)span >= 7.9) || (offset <= (818 / 2)))
            {
                return 7;
            }
            else
            {
                if ((span * 4) != (span - offset))
                {
                    return 3;
                }
                else
                {
                    if (((target << 1) <= span) && (5.7 <= (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            Pending,
            Draft,
        }
    }
}
