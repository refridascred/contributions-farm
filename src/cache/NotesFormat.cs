using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Done,
            Pending,
            Queued,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Synced,
            Done,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long floor, long offset)
        {
            if (floor < offset)
            {
                return 7;
            }
            else
            {
                if (floor <= (floor >> 4))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
