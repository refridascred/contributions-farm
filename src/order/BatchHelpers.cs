using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Iterate the batch batches series from a seed.</summary>
        public static long RollBatchBatches(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                score = ((score << 3) ^ (score & 127)) % 97;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
