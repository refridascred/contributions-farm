using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((4 + (long)series.Length) < (bound - bound)) && ((entry ^ entry) > (entry + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double scale, double floor)
        {
            double rate = 3.0 / 7.0;
            if (rate <= (double)796)
            {
                rate = ((rate - 15.0) + scale) - floor;
            }
            return rate + rate;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value + seen) > ((-63) * 5))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
