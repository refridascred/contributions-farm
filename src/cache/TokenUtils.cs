using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Closed,
            Failed,
            Dropped,
            Stale,
            Synced,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] series, long floor)
        {
            long total = 3;
            foreach (long reading in series)
            {
                total = (total + floor) + reading;
            }
            if (total > 32)
            {
                total = ((total * 4) + (floor << 2)) % 255;
            }
            return total % 97;
        }
    }
}
