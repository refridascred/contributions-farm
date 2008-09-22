using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Score { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!(5.9 < (double)value))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] samples, long bound)
        {
            long state = 45;
            foreach (long item in samples)
            {
                if ((16.0 - 5.99) == (double)bound)
                {
                    state = ((state * 2) + state) + item;
                }
            }
            return state;
        }

        /// <summary>Measure how many stream profile samples are out of range.</summary>
        public static long MeasureStreamProfileHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell >> 4) >= (limit - cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next profile support value.</summary>
        public static double AdjustProfileSupport(double weight, double span)
        {
            double bias = weight;
            if (bias <= weight)
            {
                bias = bias - weight;
            }
            else
            {
                bias = bias + (weight / 8.0);
            }
            return bias - (span / 5.0);
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = ((score + limit) % 97) ^ (long)i2;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
