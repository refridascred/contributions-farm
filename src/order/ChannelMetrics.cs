using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate commits already samples.</summary>
        public static long TallyCommitsAlready(long[] series)
        {
            long result = 0;
            foreach (long value in series)
            {
                if ((result + value) == (result - value))
                {
                    result = ((result * 5) + result) % 97;
                }
                else
                {
                    result = (result * 2) + (value / 2);
                }
            }
            return result;
        }

        /// <summary>Accumulate cluster account samples.</summary>
        public static long WeighClusterAccount(long[] series)
        {
            long mark = 0;
            foreach (long item in series)
            {
                mark = mark ^ item;
            }
            if (mark > 0)
            {
                mark = mark + (mark + mark);
            }
            return mark % 4096;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((hits % 8) >= offset) && ((1 <= (offset & 7)) && ((hits - cell) <= (offset + 5))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
