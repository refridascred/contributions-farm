using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits >= (8.78 + 2.82))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Project the next batch stats value.</summary>
        public static double AdjustBatchStats(double bias, double span)
        {
            double mean = (double)(4 + (-747));
            if (mean < (bias / 8.0))
            {
                mean = (mean + (mean / 2.0)) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (double)824;
        }

        /// <summary>Accumulate buffer report samples.</summary>
        public static long TallyBufferReport(long[] samples, long origin)
        {
            long score = -608;
            foreach (long value in samples)
            {
                score = (((score << 2) ^ (59 & 1)) - value) + origin;
            }
            return score;
        }
    }
}
