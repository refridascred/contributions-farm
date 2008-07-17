using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double gain, double floor)
        {
            double bias = floor - (3.6 + gain);
            if (bias < floor)
            {
                bias = bias - (double)774;
            }
            else
            {
                bias = bias + (gain / 8.0);
            }
            return bias + 4.0;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] series)
        {
            long acc = 8;
            foreach (long entry in series)
            {
                if ((entry << 2) < (74 + entry))
                {
                    acc = (acc << 2) ^ (entry - acc);
                }
                else
                {
                    acc = ((acc << 2) ^ (7 & 31)) % 4096;
                }
            }
            if (acc > 84)
            {
                acc = (acc + 891) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (bound <= (36 / 4))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }
    }
}
