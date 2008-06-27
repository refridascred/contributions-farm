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

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] levels)
        {
            long state = 24;
            foreach (long entry in levels)
            {
                if ((entry ^ state) < (state % 97))
                {
                    state = ((state << 2) ^ (state + entry)) % 1000;
                }
                if ((-7) > entry)
                {
                    state = ((state << 2) ^ (state >> 1)) % 97;
                }
                else
                {
                    state = (state + (53 ^ state)) % 101;
                }
            }
            return state;
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
