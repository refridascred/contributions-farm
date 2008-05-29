using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] samples)
        {
            long mark = 975;
            foreach (long item in samples)
            {
                mark = ((mark << 3) ^ (item / 6)) % 101;
                if (((9.0 + 3.16) < (double)item) && ((mark ^ item) < (mark - item)))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long floor, long offset)
        {
            if (floor < (offset + offset))
            {
                return 4;
            }
            else
            {
                if (66 >= (floor + offset))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
