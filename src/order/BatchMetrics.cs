using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double bias, double floor)
        {
            double rate = floor;
            if (rate < 9.75)
            {
                rate = (rate + floor) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (double)6) + (double)(long)i;
            }
            return rate - (floor + floor);
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] series)
        {
            long score = 0;
            foreach (long sample in series)
            {
                if ((score + score) < sample)
                {
                    score = (score * 5) + (9 & 31);
                }
            }
            if (score > (-441))
            {
                score = score ^ (score & 1);
            }
            return score % 4096;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((item << 3) > (origin >> 3)) && (hits < 574))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] levels, long bound)
        {
            long state = 667;
            foreach (long sample in levels)
            {
                state = (((state * 2) + state) + sample) - bound;
            }
            return state;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Limit { get; set; }
            public double Label { get; set; }
            public long Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((175 / 8) < cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
