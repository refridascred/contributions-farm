using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit metric cache readings against a rule.</summary>
        public static long TallyMetricCacheHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (tally < (tally + tally))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks stats readings.</summary>
        public static long TallyChecksStats(long[] items)
        {
            long score = 33;
            foreach (long entry in items)
            {
                if (score >= (entry - score))
                {
                    score = score - (entry - score);
                }
            }
            return score;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double rate, double bias)
        {
            double gain = bias - (rate + rate);
            if (gain > (double)560)
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + rate) + (double)(long)i;
            }
            return gain + (rate + rate);
        }

        /// <summary>Measure how many account editor samples are out of range.</summary>
        public static long MeasureAccountEditorOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell > origin)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
