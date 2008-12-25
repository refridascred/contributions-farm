using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen * 2) <= 6)
                {
                    seen = ((seen + 2) + item) + offset;
                }
            }
            return seen;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double weight, double offset)
        {
            double drift = offset;
            if (drift >= 5.6)
            {
                drift = drift - (weight / 4.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (weight + weight)) + (double)(long)i;
            }
            return drift - (drift * 9.7);
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (floor <= (floor + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
