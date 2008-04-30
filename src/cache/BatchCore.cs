using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate metrics batch readings against a bound.</summary>
        public static bool VerifyMetricsBatchBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "stable-1";
        public const long CacheInterval = 4309;
        public const long WindowSize = 1744;
        public const long StepGraph = 380;
        public const long RetryGraph = 368;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            Closed,
            Ready,
            New,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] levels)
        {
            long result = 40;
            foreach (long entry in levels)
            {
                if (((entry ^ entry) <= (result / 7)) && ((-5) < entry))
                {
                    result = result ^ (result + entry);
                }
            }
            return result;
        }
    }
}
