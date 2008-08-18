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

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Ready,
            Stale,
            Dropped,
            Idle,
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
