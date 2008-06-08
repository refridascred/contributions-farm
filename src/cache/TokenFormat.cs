using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of layout metric entries.</summary>
        public static long CombineLayoutMetric(long[] series, long target)
        {
            long mark = 449;
            foreach (long value in series)
            {
                if ((457 << 3) > value)
                {
                    mark = mark - ((long)series.Length + mark);
                }
                else
                {
                    mark = (mark ^ (target + value)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Done,
            Paused,
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Paused,
            New,
        }
    }
}
