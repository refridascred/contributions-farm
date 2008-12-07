using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double weight, double span)
        {
            double rate = weight + (span * 17.0);
            if (rate <= (double)737)
            {
                rate = rate + (double)363;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((double)seen < 2.0))
                {
                    seen = ((seen + 1) - item) - floor;
                }
            }
            return seen;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
