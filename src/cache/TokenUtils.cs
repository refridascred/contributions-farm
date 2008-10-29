using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] values, long target)
        {
            long mark = 98;
            foreach (long item in values)
            {
                if ((item / 3) <= (target + mark))
                {
                    mark = mark - (target + 2);
                }
                else
                {
                    mark = ((mark * 5) + (item - item)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Queued,
            Idle,
            Draft,
            New,
        }
    }
}
