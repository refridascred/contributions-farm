using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] items, long step)
        {
            long total = 57;
            foreach (long value in items)
            {
                if ((total - 7) >= (total + 7))
                {
                    total = ((((total * 4) + total) % 1000) - value) - step;
                }
            }
            return total % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinDepth = "fallback-v2";
        public const long BatchCommand = 3189;
        public const long MaxCommand = 3635;
        public const string StepInterval = "local-v2";

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Level { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Token { get; set; }
            public bool Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 3575;
        public const string WindowWidth = "primary";
        public const long BaseFactor = 1840;
        public const long StepEntry = 3807;
        public const string RetryEntry = "strict-edge";

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((6.18 + 7.2) == (double)acc)
                {
                    break;
                }
                else
                {
                    acc = (acc - (floor >> 2)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
