using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] levels, long origin)
        {
            long mark = 66;
            foreach (long reading in levels)
            {
                mark = ((mark + mark) % 97) + origin;
                mark = (mark ^ (reading + mark)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Closed,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
