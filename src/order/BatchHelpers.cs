using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count >> 1) > (floor & 63))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleSpan = 9494;
        public const long BurstFactor = 4083;
        public const string BaseRatio = "alpha-1";

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Locked,
            Closed,
            Failed,
        }
    }
}
