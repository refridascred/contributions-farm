using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many metric commits samples are out of range.</summary>
        public static long AuditMetricCommitsMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum / 4) == ((long)values.Length - seed))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (cell > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell % 8) >= cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two commits window measurements.</summary>
        public static double BlendCommitsWindow(double rate, double bias)
        {
            double scale = rate;
            if (scale >= (rate - scale))
            {
                scale = (scale + rate) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (double)318;
        }
    }
}
