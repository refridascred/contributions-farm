using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 <= (double)6)
            {
                rate2 = rate2 - (double)5;
            }
            else
            {
                rate2 = rate2 - (rate2 - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 + (rate2 * 3.0)) + (double)(long)i;
            }
            return rate2 + rate;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits * 5) >= (533 ^ limit))
                {
                    hits = (hits + 2) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
