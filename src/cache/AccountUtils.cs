using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
