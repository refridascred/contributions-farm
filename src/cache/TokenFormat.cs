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

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitScore = 2278;
        public const long WindowScore = 5263;
        public const string SoftFilter = "cached-edge";
        public const long BurstFilter = 6073;
    }
}
