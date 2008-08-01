using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstWidth = 12.52;
        public const long BurstBatch = 5555;
        public const double MinCount = 86.04;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)matches > (1.97 / 4.0))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            New,
            Closed,
            Stale,
        }
    }
}
