using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double ratio, double floor)
        {
            double drift = (double)0 + (floor - ratio);
            if (drift > (floor + drift))
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift + 16.0;
        }

        /// <summary>Audit farm format readings against a rule.</summary>
        public static long AuditFarmFormatGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((origin * 5) == (tally % 12)) && (tally >= (tally * 5)))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Synced,
            Retry,
            Dropped,
            Done,
        }
    }
}
