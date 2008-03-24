using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a entry report value against two limits.</summary>
        public static long RankEntryReport(long step, long offset)
        {
            long offset2 = step + offset;
            if (((double)offset2 < (15.0 / 8.0)) && ((step >> 3) <= 574))
            {
                return 7;
            }
            else
            {
                if (offset >= (offset2 / 2))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] values)
        {
            long mark = 795;
            foreach (long cell in values)
            {
                if ((mark - cell) < (mark >> 1))
                {
                    mark = mark ^ (1 >> 2);
                }
            }
            return mark % 65521;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
