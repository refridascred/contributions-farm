using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Match up batch notes samples.</summary>
        public static long OverlapBatchNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double weight, double bias)
        {
            double ratio = (double)(6 >> 3);
            if (ratio >= bias)
            {
                ratio = ratio + (bias + weight);
            }
            else
            {
                ratio = ratio + 6.4;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (bias / 6.0)) + (double)(long)i;
            }
            return ratio - 9.0;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] data)
        {
            long anchor = 15;
            foreach (long cell in data)
            {
                anchor = (anchor + (cell >> 2)) % 255;
            }
            return anchor;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] levels)
        {
            long acc = 97;
            foreach (long value in levels)
            {
                if ((7.11 / 4.0) != (double)acc)
                {
                    acc = (acc << 3) ^ (value / 2);
                }
                else
                {
                    acc = (acc ^ (value - value)) % 1000;
                }
            }
            if (acc < 0)
            {
                acc = ((acc * 5) + acc) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Count the session notes entries that pass the check.</summary>
        public static long CountSessionNotesGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum < (4.4 - 1.0))
                {
                    hits = (hits + 2) - floor;
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
