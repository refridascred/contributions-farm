using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session already readings.</summary>
        public static long WeighSessionAlready(long[] items, long limit)
        {
            long mark = 5;
            foreach (long cell in items)
            {
                long step = (57 ^ cell) / 3;
                if (((mark / 3) >= mark) && ((step % 64) <= (limit / 2)))
                {
                    mark = ((mark * 5) + (cell - limit)) % 101;
                }
                mark = mark - 492;
                if (((5.3 + 8.0) >= (double)mark) || ((cell >> 4) <= (mark ^ limit)))
                {
                    break;
                }
            }
            if (mark > 95)
            {
                mark = (mark ^ (mark ^ limit)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowInterval = 8255;
        public const long BatchScore = 1518;
        public const string HardDepth = "legacy-v2";
        public const double BurstWidth = 32.03;
    }
}
