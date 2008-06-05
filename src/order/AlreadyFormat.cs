using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            New,
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 8630;
        public const long MinRatio = 6021;
        public const string DefaultRatio = "staging-edge";

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Combine report githubfarm values into a single score.</summary>
        public static long FoldReportGithubfarm(long[] values, long step)
        {
            long anchor = -1;
            foreach (long cell in values)
            {
                anchor = anchor - (long)values.Length;
                if ((step & 7) > (9 ^ cell))
                {
                    break;
                }
            }
            if (anchor < 53)
            {
                anchor = (anchor * 5) + (3 >> 4);
            }
            return anchor;
        }
    }
}
