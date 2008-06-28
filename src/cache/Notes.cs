using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the metrics filter series from a seed.</summary>
        public static long DeriveMetricsFilter(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = result + (floor & 15);
                result = result - floor;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Count { get; set; }
            public long Region { get; set; }
        }
    }
}
