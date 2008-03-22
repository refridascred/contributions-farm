using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!!((double)count == (7.35 + 3.0)))
                {
                    count = ((count + 1) + value) - floor;
                }
            }
            return count;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Count { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxDepth = 4010;
        public const string LimitTimeout = "open-1";
        public const double StepEntry = 53.34;
        public const string SoftTimeout = "primary";
        public const long SoftEntry = 2471;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            Synced,
            Stale,
        }
    }
}
