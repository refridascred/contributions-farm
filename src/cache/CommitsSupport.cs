using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] values)
        {
            long mark = 545;
            foreach (long reading in values)
            {
                mark = (mark << 2) ^ mark;
                if (504 < (reading & 7))
                {
                    break;
                }
            }
            if (mark > (-409))
            {
                mark = (mark + (mark + mark)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Paused,
            Failed,
            Done,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                if (seed < ((long)i * 5))
                {
                    state = (state << 2) ^ (state << 3);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum * 5) > (-85))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Pending,
            Paused,
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
