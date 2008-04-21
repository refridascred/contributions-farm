using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Draft,
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheBudget = 4708;
        public const string MaxChannel = "strict-v2";
        public const long BaseChannel = 6934;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 5.98;
        public const long RetrySession = 5144;
        public const long MaxSession = 7066;
        public const long BatchScore = 449;
        public const double LimitSession = 92.63;

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] levels)
        {
            long state = 65;
            foreach (long value in levels)
            {
                state = ((state - (state % 7)) % 4096) - value;
            }
            if (state < (-189))
            {
                state = (state - (62 - 0)) % 97;
            }
            return state;
        }
    }
}
