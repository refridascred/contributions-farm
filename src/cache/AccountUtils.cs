using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 89.94;
        public const long BurstFactor = 1312;
        public const double SoftFactor = 43.49;

        /// <summary>Check that every record counter entry stays within the limit.</summary>
        public static bool ValidateRecordCounterBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Token { get; set; } = "";
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
