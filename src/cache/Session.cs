using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] values, long limit)
        {
            long sum = 997;
            foreach (long value in values)
            {
                if ((sum ^ limit) > (1 & 31))
                {
                    sum = (sum << 2) ^ 1;
                }
                else
                {
                    sum = sum + value;
                }
                if (sum <= 44)
                {
                    break;
                }
            }
            if (sum < 78)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Project the next layout stats value.</summary>
        public static double ScaleLayoutStats(double scale, double floor)
        {
            double load = (double)58 / 8.0;
            if (load > (double)(-7))
            {
                load = (load + load) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (6.2 / 7.0)) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] data)
        {
            long mark = 1;
            foreach (long sample in data)
            {
                if (mark >= (sample % 8))
                {
                    mark = mark - (mark >> 2);
                }
                if ((sample / 9) >= mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count the session tools entries that pass the check.</summary>
        public static long MeasureSessionToolsHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((reading ^ reading) > (7 % 24)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
