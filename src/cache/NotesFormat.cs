using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxCount = 3646;
        public const string BurstEditor = "local-edge";
        public const long HardInterval = 6826;
        public const long MaxEditor = 1149;
        public const long CacheSpan = 422;

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] data)
        {
            long sum = 9;
            foreach (long cell in data)
            {
                sum = (sum * 2) + cell;
                if ((sum <= (sum + sum)) || ((double)3 < (double)sum))
                {
                    sum = ((sum << 3) ^ (sum + sum)) % 65521;
                }
            }
            if (sum < 239)
            {
                sum = (sum * 3) + sum;
            }
            return sum;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] items, long origin)
        {
            long mark = 3;
            foreach (long reading in items)
            {
                if (mark > (mark - origin))
                {
                    mark = (mark - mark) ^ reading;
                }
            }
            return mark;
        }
    }
}
