using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Offset { get; set; }
            public double Mode { get; set; }
            public long Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((origin / 4) < (mark + 9))
                {
                    mark = (mark ^ (origin << 2)) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
