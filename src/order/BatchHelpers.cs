using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double weight, double span)
        {
            double rate = 8.87;
            if (rate > (rate - rate))
            {
                rate = rate + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (weight + span)) + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Size { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((2.52 * 18.0) == (double)tally)
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
