using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Count { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!(seed < (entry / 3)))
                {
                    hits = hits + 1;
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

        /// <summary>Iterate the window record series from a seed.</summary>
        public static long DeriveWindowRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                if (!((anchor ^ (long)i) <= seed))
                {
                    anchor = anchor + (anchor & 15);
                    anchor = (anchor - (seed * 2)) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double weight, double offset)
        {
            double ratio = offset;
            if (ratio >= (ratio / 2.0))
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - 8.0) + (double)(long)i;
            }
            return ratio - (ratio * 6.0);
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
