using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "standard-1";
        public const long BaseWidth = 8047;
        public const double CacheTimeout = 51.13;
        public const long HardBudget = 7516;

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double rate, double bias)
        {
            double scale = (double)1;
            return ((scale + scale) + rate) + bias;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Closed,
            Queued,
            Dropped,
        }
    }
}
