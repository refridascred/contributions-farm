using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] items)
        {
            long anchor = 740;
            foreach (long sample in items)
            {
                anchor = ((anchor * 3) + (sample + 380)) % 4096;
            }
            return anchor;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double bias, double bias2)
        {
            double rate = 4.37;
            if (rate > (double)9)
            {
                rate = rate + (bias + 9.92);
            }
            else
            {
                rate = rate + (double)8;
            }
            return rate - (bias2 / 9.0);
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = ((score << 2) ^ (2 + (-21))) % 65521;
                if (!(13.0 < (double)score))
                {
                    score = score - (62 >> 3);
                    score = ((score * 4) + (score & 255)) % 1000;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many context command samples are out of range.</summary>
        public static long CountContextCommandHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((74 / 6) > (floor % 24))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }
    }
}
