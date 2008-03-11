using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstInterval = 38.02;
        public const long IdleRatio = 2296;
        public const double DefaultContributi = 3.34;
        public const double RetryWidth = 59.12;
        public const string SoftContributi = "latest-1";

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] levels, long seed)
        {
            long anchor = 7;
            foreach (long datum in levels)
            {
                if (((18 - 95) > seed) && ((135 >> 4) >= (seed % 10)))
                {
                    anchor = ((anchor - anchor) % 1000) ^ datum;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxInterval = 43.41;
        public const long LimitBudget = 5957;
        public const long WindowBatch = 7832;
        public const long DefaultSpan = 2874;
        public const long MaxCount = 3292;

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 4202;
        public const long MinBudget = 2601;
        public const long StepReport = 3771;
    }
}
