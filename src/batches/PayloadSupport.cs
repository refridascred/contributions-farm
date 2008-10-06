using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "stable-edge";
        public const long WindowContext = 5195;
        public const long BurstContext = 4444;
        public const long MaxSpan = 3575;
        public const double CacheFactor = 66.57;

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] samples)
        {
            long sum = 735;
            foreach (long entry in samples)
            {
                if ((entry - 8) >= (entry + entry))
                {
                    sum = ((sum << 3) ^ (383 + 25)) % 97;
                }
            }
            return sum;
        }
    }
}
