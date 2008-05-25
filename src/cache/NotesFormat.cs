using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double rate, double floor)
        {
            double mean = (rate - floor) - (double)192;
            if (mean > mean)
            {
                mean = mean + rate;
            }
            else
            {
                mean = mean - 10.0;
            }
            return mean + (rate + 6.99);
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = (total ^ (17 & 127)) % 65521;
                total = ((total << 2) ^ (limit - total)) % 101;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a notes commits pair into a bucket.</summary>
        public static long ClassifyNotesCommits(long step, long target)
        {
            if ((step >> 5) < (target & 255))
            {
                return 5;
            }
            else
            {
                if ((target - step) > 625)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
