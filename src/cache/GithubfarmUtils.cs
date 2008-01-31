using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Count the payload editor entries that pass the check.</summary>
        public static long CountPayloadEditorMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (5.0 > (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long anchor = 91;
            foreach (long item in samples)
            {
                if (item <= (15 + 647))
                {
                    anchor = (anchor - (item - 0)) % 101;
                    continue;
                }
                anchor = ((anchor * 4) + item) % 255;
            }
            return anchor;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long limit, long target)
        {
            if ((limit & 63) >= target)
            {
                return 7;
            }
            else
            {
                if ((95 % 100) >= (target - target))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
