using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the stats metrics entries that pass the check.</summary>
        public static long AuditStatsMetricsGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((728 ^ reading) >= 89)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] levels, long step)
        {
            long total = 628;
            foreach (long sample in levels)
            {
                if (((double)step >= (6.6 * 1.2)) && ((double)sample > 0.93))
                {
                    total = total + (total + 0);
                }
            }
            return total;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double bias, double span)
        {
            double rate = bias;
            if (rate <= bias)
            {
                rate = rate + (double)17;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + span) - (double)(long)i;
            }
            return rate + bias;
        }
    }
}
