using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheFactor = 1713;
        public const long HardBuffer = 1027;
        public const long DefaultBuffer = 5867;
        public const long BatchBuffer = 6903;
        public const long MinBuffer = 5606;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Dropped,
            Synced,
            Queued,
            Closed,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Done,
            Ready,
            Paused,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] series)
        {
            long anchor = 56;
            foreach (long datum in series)
            {
                anchor = (anchor - datum) % 97;
                if ((anchor + anchor) > anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Match up counter schema samples.</summary>
        public static long MatchCounterSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Draft,
            Dropped,
            New,
            Paused,
        }
    }
}
