using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of record cache readings.</summary>
        public static long TotalRecordCache(long[] samples)
        {
            long result = 0;
            foreach (long entry in samples)
            {
                if ((entry ^ entry) < (65 / 3))
                {
                    result = result ^ (entry >> 4);
                }
            }
            return result % 1000;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up notes session samples.</summary>
        public static long MatchNotesSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank token support input into a small class.</summary>
        public static long ClassifyTokenSupport(long limit, long offset)
        {
            long edge = limit ^ offset;
            if (!((7.2 + 8.1) <= (double)edge))
            {
                return 7;
            }
            else
            {
                if (((edge * 2) <= (62 * 5)) && ((limit ^ offset) >= (488 / 2)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Failed,
            New,
        }
    }
}
