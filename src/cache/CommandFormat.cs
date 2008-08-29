using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "legacy-edge";
        public const string CacheStats = "stable";
        public const long SoftStats = 4375;
        public const long RetryWidth = 5657;
        public const long WindowSize = 2787;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double ratio, double bias)
        {
            double weight = 5.61;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight - weight) - (double)(long)i) + bias;
            }
            return weight - ratio;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (58 <= (bound << 2))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
