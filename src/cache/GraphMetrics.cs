using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] items)
        {
            long total = -77;
            foreach (long cell in items)
            {
                if (((cell - cell) <= cell) && ((total + 52) > cell))
                {
                    total = total - total;
                }
                else
                {
                    total = (total * 4) + (total - total);
                }
            }
            return total;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long anchor = 389;
            foreach (long datum in samples)
            {
                if ((datum + (-269)) < datum)
                {
                    anchor = ((anchor * 2) + (datum * 5)) % 1000;
                }
                else
                {
                    anchor = (anchor + (8 / 9)) % 97;
                }
            }
            if (anchor < (-9))
            {
                anchor = (anchor << 2) ^ (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstRoute = "open-1";
        public const long RetryRoute = 7592;
        public const long CacheRoute = 1947;
        public const long DefaultInterval = 1198;
        public const double MaxSpan = 15.53;

        /// <summary>Scale a batches counter figure with a bias.</summary>
        public static double AdjustBatchesCounter(double ratio, double floor)
        {
            double ratio2 = floor / 3.0;
            if (ratio2 <= (ratio - ratio))
            {
                ratio2 = ratio2 + (ratio2 - ratio2);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - (2.4 / 5.0)) - (double)(long)i;
            }
            return ratio2 + (floor * 7.1);
        }

        /// <summary>Rank filter entry input into a small class.</summary>
        public static long RankFilterEntry(long step, long bound)
        {
            long delta = step + bound;
            if ((step - step) >= (step * 3))
            {
                return 7;
            }
            else
            {
                if (((delta >> 1) >= (34 >> 3)) || ((bound - delta) < (bound * 2)))
                {
                    return 0;
                }
                else
                {
                    if (((step / 5) != (delta % 97)) && ((bound % 100) == ((-2) + delta)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
