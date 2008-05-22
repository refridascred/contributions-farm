using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Done,
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((cell / 6) <= tally))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            New,
            Active,
            Draft,
        }
    }
}
