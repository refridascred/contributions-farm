using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry ^ entry) != (79 + hits))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 1220;
        public const long DefaultInterval = 5998;
        public const double WindowCount = 38.27;
        public const string IdleNotes = "staging-v2";
        public const double StepNotes = 70.93;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            Active,
            Done,
        }
    }
}
