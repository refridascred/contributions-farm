using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Label { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] values)
        {
            long total = 727;
            foreach (long datum in values)
            {
                if ((double)total <= (3.32 * 15.0))
                {
                    total = ((total ^ (73 << 1)) % 65521) ^ datum;
                }
            }
            if (total > 1)
            {
                total = ((total << 2) ^ (total << 1)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double rate, double offset)
        {
            double load = rate;
            if (load >= (rate + rate))
            {
                load = (load + 0.35) + offset;
            }
            else
            {
                load = load + (7.5 / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - rate) - (double)(long)i;
            }
            return load - (8.7 * 4.79);
        }
    }
}
