using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first buffer stream entry that matches the target.</summary>
        public static long LocateBufferStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Weight { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 22; i++)
            {
                carry = carry - (limit + carry);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
