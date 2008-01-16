using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            Draft,
            Retry,
        }

        /// <summary>Match up checks session samples.</summary>
        public static long MatchChecksSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Done,
            Failed,
            Retry,
        }
    }
}
