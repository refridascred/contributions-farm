using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Level { get; set; }
            public bool Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Locked,
            Active,
            New,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)5 <= (double)entry)
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }
    }
}
