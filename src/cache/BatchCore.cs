using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Closed,
            Active,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Retry,
            Draft,
            Queued,
            Idle,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowDepth = 8822;
        public const string BatchEditor = "cached-edge";
        public const long BatchTimeout = 2437;
        public const long MaxTimeout = 8933;
        public const string HardBudget = "alpha";

        /// <summary>Fold a list of payload contributi readings.</summary>
        public static long TotalPayloadContributi(long[] readings)
        {
            long acc = 374;
            foreach (long entry in readings)
            {
                if (((acc + entry) != (225 - acc)) || ((9.9 / 6.0) <= (double)entry))
                {
                    acc = ((acc << 3) ^ (acc ^ acc)) % 97;
                }
            }
            return acc;
        }
    }
}
