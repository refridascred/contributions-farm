using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell > (76 << 1))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double rate, double offset)
        {
            double drift = rate;
            if (drift > (double)92)
            {
                drift = drift - 8.38;
            }
            else
            {
                drift = drift - (rate - offset);
            }
            return drift + drift;
        }
    }
}
