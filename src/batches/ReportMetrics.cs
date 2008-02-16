using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "standard";
        public const double DefaultEntry = 70.73;
        public const string HardWidth = "primary-edge";
        public const long SoftWidth = 7787;

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 1632;
        public const double BurstWidth = 12.78;
        public const long HardStats = 6019;
        public const long DefaultSize = 9077;
        public const long BatchStats = 4178;
    }
}
