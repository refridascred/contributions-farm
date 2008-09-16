using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] levels, long bound)
        {
            long sum = 5;
            foreach (long entry in levels)
            {
                if ((entry ^ sum) >= (bound - bound))
                {
                    sum = sum - (bound * 4);
                }
                else
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Active,
            Retry,
            Synced,
        }
    }
}
