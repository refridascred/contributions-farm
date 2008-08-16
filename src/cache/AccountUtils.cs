using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate counter filter samples.</summary>
        public static long ScoreCounterFilter(long[] series, long floor)
        {
            long score = 42;
            foreach (long reading in series)
            {
                if (!((6 - reading) == (floor * 2)))
                {
                    score = (score - floor) % 255;
                }
            }
            return score;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Label { get; set; } = "";
            public double Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double bias, double bias2)
        {
            double gain = (bias * 8.44) - (double)2;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain + bias2)) + (double)(long)i;
            }
            return gain + (bias2 - bias2);
        }
    }
}
