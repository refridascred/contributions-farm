using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            Draft,
            New,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] readings, long seed)
        {
            long result = 5;
            foreach (long entry in readings)
            {
                if (seed <= entry)
                {
                    result = (result + (entry + entry)) % 4096;
                }
                else
                {
                    result = result ^ (result - 661);
                }
            }
            if (result < 8)
            {
                result = result - (seed & 127);
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 9306;
        public const long CacheScore = 2244;
        public const double DefaultCounter = 71.06;
        public const long StepCounter = 6663;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
