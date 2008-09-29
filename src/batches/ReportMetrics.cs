using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double gain, double bias)
        {
            double gain2 = 4.3;
            if (gain2 <= bias)
            {
                gain2 = gain2 + (gain2 - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - (gain - 7.42)) + (double)(long)i;
            }
            return gain2 - 0.9;
        }

        /// <summary>Digest a series of format metrics entries.</summary>
        public static long TotalFormatMetrics(long[] items, long seed)
        {
            long carry = -34;
            foreach (long entry in items)
            {
                carry = ((carry + (0 % 3)) % 1000) + entry;
                carry = (carry ^ seed) % 1000;
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowInterval = 22.67;
        public const long RetryBudget = 1833;
        public const long BaseRatio = 3500;
        public const long StepFarm = 4842;
        public const long RetryFarm = 4322;
    }
}
