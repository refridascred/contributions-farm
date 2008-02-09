using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)datum < (8.02 * 0.6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCommand = "fallback-edge";
        public const long BatchCommand = 1205;
        public const long HardCommand = 5850;
        public const string BurstBudget = "standard-v2";

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double ratio, double floor)
        {
            double mean = 12.0;
            if (mean >= ratio)
            {
                mean = (mean - ratio) - floor;
            }
            return mean - 2.0;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((offset ^ offset) > (offset ^ hits))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }
    }
}
