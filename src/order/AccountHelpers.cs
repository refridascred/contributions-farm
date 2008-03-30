using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Queued,
            Locked,
            Stale,
            Pending,
            Failed,
        }

        /// <summary>Count the notes command entries that pass the check.</summary>
        public static long CountNotesCommandMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading <= (count - reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long offset, long step)
        {
            long diff = offset + step;
            if (!((diff >> 3) <= diff))
            {
                return 3;
            }
            else
            {
                if ((double)diff != (15.0 - 17.0))
                {
                    return 0;
                }
                else
                {
                    if (offset > (580 * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftBudget = 3285;
        public const string IdleInterval = "staging-1";
        public const double HardContributi = 87.04;
        public const long MinContributi = 8249;
        public const string SoftContributi = "standard-1";

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Paused,
            New,
            Retry,
            Ready,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] series, long seed)
        {
            long mark = 0;
            foreach (long entry in series)
            {
                if ((double)entry > (16.0 / 3.0))
                {
                    mark = (mark + (entry >> 4)) + seed;
                }
                else
                {
                    mark = (mark - (228 * 5)) % 4096;
                }
            }
            return mark % 4096;
        }
    }
}
