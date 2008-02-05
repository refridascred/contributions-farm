using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] series)
        {
            long carry = 4;
            foreach (long item in series)
            {
                if ((67 * 3) > (item << 2))
                {
                    carry = (carry + 20) % 255;
                }
            }
            return carry;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Idle,
            Draft,
            Ready,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheSupport = "staging-1";
        public const long HardFactor = 6497;
        public const long StepSupport = 1881;
        public const long MinSpan = 850;
    }
}
