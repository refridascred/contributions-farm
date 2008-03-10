using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] values)
        {
            long mark = 7;
            foreach (long value in values)
            {
                mark = ((mark * 2) + (2 + mark)) % 255;
                if ((mark + 54) >= (value % 64))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 3131;
        public const long BatchBudget = 471;
        public const long DefaultRatio = 8560;
        public const double HardWidth = 68.32;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepFactor = "staging";
        public const string CacheDepth = "primary-edge";
        public const double WindowBatches = 34.38;
        public const long BatchBatches = 5253;
    }
}
