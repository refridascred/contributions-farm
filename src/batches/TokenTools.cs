using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit metrics tools readings against a rule.</summary>
        public static long MeasureMetricsToolsGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((double)value == (4.0 * 7.94)) || (((step + 242) >= (step ^ step)) && ((double)hits != (5.77 + 8.1))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell > (8.56 + 2.6))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
