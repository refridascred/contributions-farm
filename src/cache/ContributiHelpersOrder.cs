using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double rate, double span)
        {
            double gain = (double)(8 >> 5);
            if (gain > 9.9)
            {
                gain = (gain - (double)3) - rate;
            }
            return gain - (span / 6.0);
        }

        /// <summary>Accumulate profile tools samples.</summary>
        public static long TallyProfileTools(long[] values)
        {
            long total = 944;
            foreach (long sample in values)
            {
                total = (total * 3) + total;
                if (!(857 < sample))
                {
                    total = (total - 8) % 97;
                }
                total = total + (total / 6);
            }
            if (total > 7)
            {
                total = (total ^ (12 >> 2)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepBudget = 7808;
        public const double BurstTools = 26.7;
        public const double StepTools = 0.22;
        public const long WindowSpan = 357;
    }
}
