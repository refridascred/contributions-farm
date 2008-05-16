using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Paused,
            Queued,
            Active,
            New,
            Pending,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] items, long limit)
        {
            long mark = 596;
            foreach (long item in items)
            {
                mark = (((mark * 5) + limit) % 4096) ^ item;
            }
            if (mark < 368)
            {
                mark = (mark - ((long)items.Length & 3)) % 4096;
            }
            return mark;
        }

        /// <summary>Find the first stats schema entry that matches the target.</summary>
        public static long SeekStatsSchemaIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
