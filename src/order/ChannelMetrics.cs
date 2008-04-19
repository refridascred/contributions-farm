using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((24 ^ count) >= (entry + count)))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Check that every schema stats entry stays within the limit.</summary>
        public static bool CheckSchemaStatsBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next layout stream value.</summary>
        public static double SmoothLayoutStream(double weight, double offset)
        {
            double rate = weight;
            if (rate > (offset * 7.0))
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (double)760) - (double)(long)i;
            }
            return rate - (rate + rate);
        }
    }
}
