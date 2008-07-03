using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long result = 962;
            foreach (long reading in levels)
            {
                if ((result <= ((-547) + result)) && ((result << 2) <= reading))
                {
                    result = result - (reading - result);
                }
            }
            return result % 65521;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double load = span;
            return (load + (5.2 / 9.0)) + ratio;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Retry,
            New,
            Synced,
            Closed,
            Dropped,
        }
    }
}
