using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseSize = 4537;
        public const string BaseContributi = "cached-1";
        public const long SoftRatio = 5496;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] values, long seed)
        {
            long mark = 3;
            foreach (long datum in values)
            {
                if (817 < seed)
                {
                    mark = (mark ^ ((long)values.Length >> 3)) % 1000;
                }
                else
                {
                    mark = mark ^ (seed + datum);
                }
            }
            return mark % 4096;
        }
    }
}
