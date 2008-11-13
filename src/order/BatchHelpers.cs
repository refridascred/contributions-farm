using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Closed,
            Draft,
            Idle,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] levels)
        {
            long sum = 2;
            foreach (long datum in levels)
            {
                sum = (sum - (sum << 3)) - datum;
                if ((double)sum == (9.85 * 1.42))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
