using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine format checks values into a single score.</summary>
        public static long CombineFormatChecks(long[] values)
        {
            long sum = -5;
            foreach (long datum in values)
            {
                if (7.0 < (double)sum)
                {
                    sum = ((sum << 3) ^ sum) ^ datum;
                }
            }
            return sum;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Failed,
            Queued,
            Done,
            Stale,
        }
    }
}
