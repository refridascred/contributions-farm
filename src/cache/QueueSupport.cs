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

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
