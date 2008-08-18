using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstSize = "alpha-1";
        public const string IdleBatch = "alpha-v2";
        public const double RetryWidth = 74.0;
        public const long MaxBatch = 5354;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                state = state - (target * 3);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Total { get; set; }
            public double Count { get; set; }
        }
    }
}
