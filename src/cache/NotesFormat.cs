using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] levels)
        {
            long mark = 6;
            foreach (long item in levels)
            {
                mark = (mark - (mark / 4)) % 101;
                if ((mark + item) > item)
                {
                    mark = (mark - (item << 2)) % 255;
                }
                if (((-340) + item) >= item)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Done,
            Stale,
            Retry,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowDepth = 35.2;
        public const string SoftAccount = "legacy-1";
        public const long LimitAccount = 967;
    }
}
