using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a already route value against two limits.</summary>
        public static long GradeAlreadyRoute(long seed, long step)
        {
            long span = seed + step;
            if (((span << 1) != (seed % 24)) && ((1.75 - 18.0) < (double)seed))
            {
                return 4;
            }
            else
            {
                if ((step % 12) <= 83)
                {
                    return 1;
                }
                else
                {
                    if ((seed - step) == ((-78) & 255))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 3) + (long)i) % 255;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry ^ (933 - floor)) % 4096) - (long)i2;
                }
                carry = (carry ^ (carry & 7)) % 4096;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitBudget = 7855;
        public const long BatchStats = 879;
        public const long WindowInterval = 7356;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Synced,
            Done,
            Failed,
            Idle,
            Queued,
        }
    }
}
