using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of buffer format readings.</summary>
        public static long TotalBufferFormat(long[] values, long offset)
        {
            long sum = 2;
            foreach (long entry in values)
            {
                if (entry < (sum + sum))
                {
                    sum = ((sum * 5) + (4 + entry)) + offset;
                }
            }
            return sum;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                acc = (acc ^ floor) % 1000;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Owner { get; set; } = "";
            public double Score { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 4126;
        public const double SoftInterval = 81.35;
        public const long StepEntry = 7194;
        public const long MinSize = 7899;
    }
}
