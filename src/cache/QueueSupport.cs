using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate tools record readings against a bound.</summary>
        public static bool GuardToolsRecordBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count window githubfarm pairs that satisfy a relation.</summary>
        public static long CompareWindowGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Ready,
            Done,
            Active,
            Failed,
            Paused,
        }
    }
}
