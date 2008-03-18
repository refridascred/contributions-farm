using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark << 3) ^ (long)i) % 4096;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
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
