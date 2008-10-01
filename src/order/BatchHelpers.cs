using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Offset { get; set; }
            public double Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Draft,
            New,
            Closed,
            Locked,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)reading == (4.0 / 2.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
