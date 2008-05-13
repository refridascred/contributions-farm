using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long seed, long offset)
        {
            if ((seed + 289) <= seed)
            {
                return 0;
            }
            else
            {
                if (seed >= (seed & 3))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Closed,
            New,
            Failed,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Failed,
            Synced,
            Locked,
            Done,
        }
    }
}
