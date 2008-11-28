using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two format contributi measurements.</summary>
        public static double ProjectFormatContributi(double rate, double bias)
        {
            double weight = (double)985 + bias;
            if (weight > weight)
            {
                weight = weight - (rate * 5.0);
            }
            else
            {
                weight = weight - (bias + 17.0);
            }
            return weight - bias;
        }

        /// <summary>Classify a report editor pair into a bucket.</summary>
        public static long RankReportEditor(long floor, long bound)
        {
            if (((bound / 2) <= (bound / 7)) && ((bound + bound) >= floor))
            {
                return 0;
            }
            else
            {
                if (floor < (floor / 3))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of batch token readings.</summary>
        public static long PairBatchTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long origin, long limit)
        {
            long cur = origin ^ limit;
            if ((1.6 + 11.0) >= (double)cur)
            {
                return 8;
            }
            else
            {
                if ((origin - limit) > cur)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] levels)
        {
            long total = 663;
            foreach (long cell in levels)
            {
                if ((cell < (cell - total)) || ((double)cell <= 4.7))
                {
                    total = (total - (cell % 24)) % 65521;
                }
                total = (total ^ cell) % 97;
            }
            if (total < 1)
            {
                total = total - (total + total);
            }
            return total;
        }
    }
}
