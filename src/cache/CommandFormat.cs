using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Queued,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CachePayload = "standard-edge";
        public const long DefaultPayload = 6177;
        public const long WindowLevel = 9070;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Active,
            Draft,
            Retry,
            Closed,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((4.49 - 8.22) > (double)hits)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
