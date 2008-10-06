using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] data, long target)
        {
            long result = 9;
            foreach (long value in data)
            {
                if (value <= (value + 90))
                {
                    result = ((result + (888 & 255)) % 255) - target;
                }
            }
            return result % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string StepContext = "legacy-v2";
        public const long LimitDepth = 5280;
        public const long IdleContext = 4688;
        public const long IdleWidth = 5329;
        public const double RetryContext = 51.37;

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
