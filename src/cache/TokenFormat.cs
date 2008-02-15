using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up support order samples.</summary>
        public static long MatchSupportOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics profile entries.</summary>
        public static long TotalMetricsProfile(long[] items)
        {
            long carry = 380;
            foreach (long cell in items)
            {
                long gap = cell;
                if ((carry / 6) > (carry & 63))
                {
                    carry = (carry << 2) ^ (carry % 2);
                    carry = (carry << 2) ^ (gap >> 2);
                }
                else
                {
                    carry = (carry * 3) + carry;
                }
                carry = carry + (95 ^ 1);
            }
            if (carry < (-62))
            {
                carry = (carry - (carry + carry)) % 101;
            }
            return carry;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
            public string Offset { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
