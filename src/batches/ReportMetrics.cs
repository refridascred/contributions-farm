using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstWidth = "open";
        public const long LimitBatch = 1611;
        public const long BurstBatch = 9578;
        public const double RetryBatch = 78.17;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheCount = "cached-edge";
        public const long MinTimeout = 6567;
        public const long WindowFactor = 9218;
        public const long StepBuffer = 7784;
        public const long StepBudget = 6275;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
