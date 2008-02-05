using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] levels)
        {
            long mix = 7;
            foreach (long value in levels)
            {
                mix = (mix - (value ^ value)) % 97;
            }
            if (mix > 98)
            {
                mix = (mix + (555 + mix)) % 4096;
            }
            return mix % 1000;
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
