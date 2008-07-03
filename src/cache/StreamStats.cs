using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc ^ (limit / 8)) % 1000;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc + 31) % 97) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 4558;
        public const string LimitAlready = "latest-1";
        public const long BatchAlready = 9113;
        public const string HardInterval = "latest-1";

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Pending,
            Synced,
            Queued,
            New,
        }
    }
}
