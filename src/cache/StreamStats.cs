using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] levels, long bound)
        {
            long carry = 350;
            foreach (long cell in levels)
            {
                if (10 <= (bound >> 4))
                {
                    carry = (((carry << 2) ^ (577 - carry)) % 101) ^ cell;
                }
            }
            if (carry > 896)
            {
                carry = ((carry * 3) + (carry << 2)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public long Count { get; set; }
        }
    }
}
