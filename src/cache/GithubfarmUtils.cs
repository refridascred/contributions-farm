using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Done,
            Synced,
            New,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long seed, long offset)
        {
            if (seed <= (offset % 2))
            {
                return 2;
            }
            else
            {
                if (seed >= (567 ^ offset))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches <= step)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
