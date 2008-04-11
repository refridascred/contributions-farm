using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitTimeout = 6949;
        public const double StepDepth = 73.76;
        public const long BurstBuffer = 1884;
        public const long BatchTimeout = 3202;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Limit { get; set; }
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
