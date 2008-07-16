using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double rate, double span)
        {
            double scale = (double)(373 / 4);
            return (scale - (span / 5.0)) + rate;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (datum >= (matches >> 3))
                {
                    matches = (matches + 2) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftLevel = 87.38;
        public const long DefaultSchema = 9674;
        public const long IdleBudget = 9175;
        public const long WindowSchema = 4090;
        public const long SoftSchema = 3317;
    }
}
