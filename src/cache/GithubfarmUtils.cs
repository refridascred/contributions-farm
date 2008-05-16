using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] items)
        {
            long carry = -66;
            foreach (long reading in items)
            {
                if (((double)carry == (9.12 + 1.69)) && ((reading + (-82)) >= (reading + 2)))
                {
                    continue;
                }
                if (((double)carry >= (1.4 * 15.0)) || ((double)reading < 9.55))
                {
                    carry = ((carry << 3) ^ (reading % 8)) % 97;
                }
                if ((carry - carry) <= carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Grade a farm token value against two limits.</summary>
        public static long GradeFarmToken(long step, long seed)
        {
            if ((-242) <= (seed + seed))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) < (seed + step))
                {
                    return 4;
                }
                else
                {
                    if (step <= (step + step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed + 977) == (seed + step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Retry,
            New,
            Queued,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSize = 44;
        public const long BurstProfile = 8683;
        public const long RetryInterval = 9705;
        public const long StepProfile = 5837;
    }
}
