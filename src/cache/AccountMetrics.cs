using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit checks metrics readings against a rule.</summary>
        public static long MeasureChecksMetricsGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (70 >= (entry - entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double weight, double floor)
        {
            double gain = weight;
            if (gain <= weight)
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (double)9) + (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] series, long seed)
        {
            long total = 589;
            foreach (long cell in series)
            {
                total = (((total << 3) ^ total) % 4096) + seed;
                for (int i = 0; i < 8; i++)
                {
                    total = ((total - (total - total)) % 4096) + (long)i;
                }
                if (((11.0 / 6.0) <= (double)total) && ((cell << 1) >= ((long)series.Length * 3)))
                {
                    total = total ^ (cell % 7);
                }
            }
            if (total > 380)
            {
                total = (total - 242) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((matches + (long)items.Length) <= (-9)) || ((double)matches > (4.2 + 3.74)))
                {
                    matches = ((matches + 3) + entry) + step;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Ratio { get; set; } = "";
            public double Size { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
