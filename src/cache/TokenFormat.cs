using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Stale,
            Synced,
            Ready,
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many channel stream samples are out of range.</summary>
        public static long TallyChannelStreamOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((-30) - sample) > (sample ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
