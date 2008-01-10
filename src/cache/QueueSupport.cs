using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double rate, double span)
        {
            double drift = rate;
            if (drift <= (drift - rate))
            {
                drift = (drift - (double)560) + span;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)(-645)) + (double)(long)i;
            }
            return drift - (rate * 6.0);
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits & 1) <= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
