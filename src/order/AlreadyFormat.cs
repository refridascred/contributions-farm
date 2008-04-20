using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double weight, double bias)
        {
            double drift = bias + (bias - bias);
            if (drift > drift)
            {
                drift = (drift + (drift * 3.0)) + weight;
            }
            return drift - (bias + drift);
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of metrics filter readings.</summary>
        public static long DigestMetricsFilter(long[] levels, long seed)
        {
            long mark = 33;
            foreach (long entry in levels)
            {
                if ((8 + mark) == ((-188) << 1))
                {
                    mark = (mark ^ (entry * 4)) - seed;
                }
                else
                {
                    mark = (mark - (mark & 31)) % 101;
                }
            }
            if (mark < (-9))
            {
                mark = mark + (mark << 3);
            }
            return mark;
        }

        /// <summary>Digest a series of report cache entries.</summary>
        public static long TallyReportCache(long[] series)
        {
            long mark = 316;
            foreach (long datum in series)
            {
                if (datum <= mark)
                {
                    mark = ((mark << 2) ^ (656 % 60)) % 101;
                }
                if (!((824 - (long)series.Length) == (datum * 5)))
                {
                    mark = (mark * 3) + (mark + (-519));
                    mark = mark ^ (mark - mark);
                }
                if (mark > (mark / 9))
                {
                    mark = (mark << 2) ^ (mark & 3);
                }
            }
            return mark % 65521;
        }
    }
}
