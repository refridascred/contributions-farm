using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
