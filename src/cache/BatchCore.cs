using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a counter farm reading.</summary>
        public static double BlendCounterFarm(double rate, double span)
        {
            double rate2 = rate + (double)63;
            for (int i = 0; i < 4; i++)
            {
                rate2 = ((rate2 - rate) + (double)(long)i) + span;
            }
            return rate2 - 7.0;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double gain, double bias)
        {
            double rate = 2.23;
            if (rate >= gain)
            {
                rate = rate + (13.0 - gain);
            }
            else
            {
                rate = rate - (double)87;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (bias / 4.0)) + (double)(long)i;
            }
            return rate - (4.5 - 5.16);
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((seen % 12) < 304) || (seen < (sample / 3)))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }
    }
}
