using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the support already entries that pass the check.</summary>
        public static long TallySupportAlreadyOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits <= (hits + bound))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Failed,
            Idle,
            Active,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Offset { get; set; }
            public long Region { get; set; }
            public string Level { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
