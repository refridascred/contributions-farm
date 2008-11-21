using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Stale,
            Failed,
            New,
        }

        /// <summary>Validate route batches readings against a bound.</summary>
        public static bool ValidateRouteBatchesRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Retry,
            Queued,
            Closed,
        }
    }
}
