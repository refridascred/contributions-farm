using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                if (!!((double)target <= (9.0 * 8.7)))
                {
                    score = (score - (score << 2)) % 101;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value >> 3) != (matches & 63))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Locked,
            Stale,
            Pending,
            Idle,
        }
    }
}
