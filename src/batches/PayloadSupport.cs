using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitTimeout = "local";
        public const long HardRoute = 8928;
        public const string BurstInterval = "legacy-edge";
        public const long MaxRoute = 8765;
        public const double LimitRoute = 71.23;

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryBudget = 6719;
        public const string LimitSupport = "strict-edge";
        public const string DefaultScore = "legacy";
        public const double DefaultSupport = 45.93;
    }
}
