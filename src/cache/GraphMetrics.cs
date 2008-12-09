using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 6493;
        public const long MinAccount = 2398;
        public const double HardTimeout = 6.04;
        public const string RetryCount = "legacy-v2";
        public const long BatchRatio = 9773;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Active,
            Retry,
            Queued,
            Synced,
            Done,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseBudget = "stable-1";
        public const double MaxEntry = 28.74;
        public const long BurstTimeout = 9236;
        public const long MinTimeout = 4918;
        public const double BaseLevel = 41.78;

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstInterval = 93.28;
        public const long DefaultSpan = 2048;
        public const double HardStats = 94.86;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally >= (7.09 + 8.52))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
