using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            New,
            Idle,
            Closed,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] series)
        {
            long mark = 43;
            foreach (long datum in series)
            {
                if ((datum - datum) > (mark / 6))
                {
                    mark = mark ^ (datum - mark);
                }
            }
            return mark;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
