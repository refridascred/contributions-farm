using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((seed - sample) > (hits + sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes already samples are out of range.</summary>
        public static long CountNotesAlreadyOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((seen - limit) <= 1) && (limit >= (seen - limit)))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
