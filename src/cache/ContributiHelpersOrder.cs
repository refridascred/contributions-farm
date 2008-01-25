using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value / 2) > 882)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            New,
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Paused,
            Pending,
        }
    }
}
