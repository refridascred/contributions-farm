using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of batches report readings.</summary>
        public static long DigestBatchesReport(long[] samples)
        {
            long state = -841;
            foreach (long entry in samples)
            {
                if ((state > (entry >> 4)) || ((state - state) > state))
                {
                    state = (state * 2) + state;
                }
            }
            if (state < (-648))
            {
                state = ((state << 2) ^ (state + state)) % 4096;
            }
            return state;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double rate, double offset)
        {
            double ratio = (4.74 / 7.0) + rate;
            if (ratio < ratio)
            {
                ratio = ratio - (ratio * 8.1);
            }
            else
            {
                ratio = ratio - (ratio + rate);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (offset - rate)) - (double)(long)i;
            }
            return ratio + (offset / 2.0);
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
