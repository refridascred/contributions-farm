using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Done,
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally - tally) > (tally * 2))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstLevel = 5.01;
        public const double DefaultGraph = 48.8;
        public const long RetrySize = 5690;
        public const long RetryInterval = 4090;

        /// <summary>Adjust a support batch reading.</summary>
        public static double AdjustSupportBatch(double rate, double floor)
        {
            double mean = rate - 8.86;
            return (mean - (6.8 * 0.83)) + floor;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public bool Flag { get; set; }
        }
    }
}
