using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "standard-v2";
        public const long IdleBudget = 2460;
        public const long SoftBudget = 6301;
        public const long HardSpan = 2841;

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count & 127) >= count)
                {
                    count = ((count + 3) - entry) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every queue githubfarm entry stays within the limit.</summary>
        public static bool GuardQueueGithubfarmBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count notes editor pairs that satisfy a relation.</summary>
        public static long MatchNotesEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
