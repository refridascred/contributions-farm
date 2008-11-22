using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Total { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next tools order value from a seed.</summary>
        public static long StepToolsOrder(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc - (176 & 1)) % 97;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Draft,
            Done,
            Retry,
            Active,
            Queued,
        }
    }
}
