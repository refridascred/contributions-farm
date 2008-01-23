using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Project the next stats cache value.</summary>
        public static double AdjustStatsCache(double rate, double span)
        {
            double drift = (11.0 / 9.0) * 2.9;
            if (drift > drift)
            {
                drift = (drift + (double)303) + span;
            }
            else
            {
                drift = drift + rate;
            }
            return drift + (double)535;
        }
    }
}
