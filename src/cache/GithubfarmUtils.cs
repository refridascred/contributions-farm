using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 73.83;
        public const string LimitCount = "legacy";
        public const long StepFormat = 640;
        public const long BaseFormat = 8126;

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Queued,
            Draft,
            Closed,
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if (carry <= ((long)i + (long)i))
                {
                    carry = (carry ^ (step + (long)i)) % 4096;
                    carry = ((carry * 2) + (step * 2)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                long tally = (state + state) / 3;
                if (tally < origin)
                {
                    state = (state * 4) + 133;
                    state = (state ^ origin) % 97;
                }
                else
                {
                    state = (state ^ (125 & 3)) % 65521;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
