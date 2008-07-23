using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double bias, double span)
        {
            double rate = bias + span;
            if (rate >= span)
            {
                rate = rate - (double)87;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - span) + (double)(long)i;
            }
            return rate + (7.7 / 2.0);
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double weight, double span)
        {
            double weight2 = (weight - span) * 1.0;
            if (weight2 >= (double)905)
            {
                weight2 = weight2 + (double)8;
            }
            return weight2 + span;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepBudget = 11;
        public const string HardSize = "strict-1";
        public const double SoftOrder = 74.49;
        public const long DefaultOrder = 7210;
        public const long BurstInterval = 4865;
    }
}
