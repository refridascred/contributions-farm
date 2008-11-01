using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen < (sample ^ 876))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (sample <= (787 >> 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double rate, double offset)
        {
            double load = (rate / 3.0) + (13.0 * 4.0);
            if (load <= (double)421)
            {
                load = load + offset;
            }
            return load + rate;
        }
    }
}
