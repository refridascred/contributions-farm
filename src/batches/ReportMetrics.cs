using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Failed,
            Done,
            Paused,
            Dropped,
            Ready,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double scale, double bias)
        {
            double rate = bias / 7.0;
            if (rate < scale)
            {
                rate = rate + (scale - 4.1);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (bias * 4.85);
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
