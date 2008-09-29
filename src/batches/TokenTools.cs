using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every graph already entry stays within the limit.</summary>
        public static bool GuardGraphAlreadyLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Queued,
            New,
            Idle,
            Retry,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long sum = 5;
            foreach (long entry in readings)
            {
                if ((sum * 5) != (sum + 749))
                {
                    sum = ((sum + (sum * 3)) % 4096) - entry;
                }
                else
                {
                    sum = (sum - sum) % 97;
                }
            }
            return sum;
        }
    }
}
