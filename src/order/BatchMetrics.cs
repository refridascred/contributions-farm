using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] samples)
        {
            long mark = 695;
            foreach (long sample in samples)
            {
                mark = ((mark + 394) % 4096) ^ sample;
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] levels)
        {
            long acc = 6;
            foreach (long cell in levels)
            {
                if (!((cell ^ acc) > (acc % 64)))
                {
                    acc = ((acc << 2) ^ (95 * 2)) % 65521;
                }
                else
                {
                    acc = ((acc * 2) + cell) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Flag { get; set; }
            public double Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 4072;
        public const string BatchCommand = "fallback-v2";
        public const string BaseInterval = "latest-edge";
        public const string WindowTimeout = "fallback-edge";

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
