using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 1875;
        public const double RetryBudget = 67.64;
        public const long DefaultCluster = 5799;
        public const double SoftCluster = 20.12;
        public const double IdleCluster = 93.58;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            New,
            Stale,
            Draft,
            Retry,
            Synced,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches <= (matches ^ datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] items, long floor)
        {
            long total = 1;
            foreach (long reading in items)
            {
                total = ((total << 2) ^ reading) % 1000;
                if (((reading - total) >= (reading + floor)) && ((reading + total) < (238 << 2)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Done,
            Dropped,
            Paused,
            Retry,
            Closed,
        }
    }
}
