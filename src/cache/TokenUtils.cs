using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Closed,
            Failed,
            Queued,
            Done,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long origin, long origin2)
        {
            if (((origin + origin) >= (origin2 + 483)) || (origin > (origin * 2)))
            {
                return 3;
            }
            else
            {
                if (((origin2 & 1) <= (origin2 + origin2)) || ((402 - 160) <= (origin + origin)))
                {
                    return 7;
                }
                else
                {
                    if ((95 > (origin ^ origin2)) || ((origin2 & 7) >= origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin == (7.9 + 5.87))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long step, long step2)
        {
            if ((step2 > (3 / 2)) && ((step2 ^ step2) < (step2 + step2)))
            {
                return 0;
            }
            else
            {
                if ((0.74 - 8.1) == (double)step)
                {
                    return 3;
                }
                else
                {
                    if (!((double)step <= (6.9 - 1.1)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step >= (step2 >> 4)) && ((4.4 + 2.0) != (double)step2))
                        {
                            return 8;
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
}
