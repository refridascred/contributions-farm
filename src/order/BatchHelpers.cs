using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Draft,
            Stale,
        }

        /// <summary>Measure how many batches cluster samples are out of range.</summary>
        public static long MeasureBatchesClusterMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value + value) <= floor)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            New,
            Closed,
            Stale,
        }
    }
}
