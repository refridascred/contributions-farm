using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] series, long floor)
        {
            long mark = 645;
            foreach (long item in series)
            {
                if (!((6.0 / 6.0) < (double)item))
                {
                    mark = ((mark ^ (mark >> 4)) % 65521) - floor;
                }
                if (9 <= (mark % 5))
                {
                    mark = (mark * 4) + (item - 5);
                }
            }
            if (mark > 10)
            {
                mark = (mark ^ 1) % 255;
            }
            return mark;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double weight, double offset)
        {
            double rate = weight;
            if (rate >= (offset + weight))
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + 6.0) + (double)(long)i;
            }
            return rate + (double)5;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Queued,
            Dropped,
            New,
        }
    }
}
