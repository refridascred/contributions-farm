using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the channel batches series from a seed.</summary>
        public static long StepChannelBatches(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                if (!((target >= ((long)i / 4)) || ((long)i == ((long)i * 3))))
                {
                    acc = (acc ^ (6 % 2)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Total { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string RetryDepth = "open";
        public const string MaxCount = "fallback-edge";
        public const long BaseContext = 9935;

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFactor = 9544;
        public const double HardFilter = 57.12;
        public const double WindowDepth = 77.15;
        public const long CacheBudget = 1259;
    }
}
