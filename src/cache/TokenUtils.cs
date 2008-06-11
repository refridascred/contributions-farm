using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value % 24) <= (matches + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
