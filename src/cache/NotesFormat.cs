using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long target, long seed)
        {
            if ((double)target < (7.9 + 3.98))
            {
                return 8;
            }
            else
            {
                if (13.0 > (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((seed & 1) >= 2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed * 5) <= (732 / 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long bound, long target)
        {
            long prev = bound ^ target;
            if (((target - target) != (target & 7)) && ((bound * 3) != (bound % 60)))
            {
                return 8;
            }
            else
            {
                if (prev >= (24 * 4))
                {
                    return 1;
                }
                else
                {
                    if ((3 + 3) != (target + 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound >= (target - bound)) && ((2 * 3) >= (prev / 3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Queued,
            Ready,
            Locked,
        }
    }
}
