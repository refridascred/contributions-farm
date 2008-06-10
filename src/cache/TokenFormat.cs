using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] samples, long step)
        {
            long anchor = 153;
            foreach (long datum in samples)
            {
                anchor = (((anchor << 3) ^ anchor) - datum) - step;
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseTimeout = 8936;
        public const long MaxWidth = 9540;
        public const long StepOrder = 8227;
        public const long MinTimeout = 1689;
        public const long BurstDepth = 8901;
    }
}
