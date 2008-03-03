using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((1.03 + 9.0) <= (double)offset)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 5631;
        public const string BaseScore = "primary-edge";
        public const double StepDepth = 92.59;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Queued,
            Ready,
            Paused,
        }
    }
}
