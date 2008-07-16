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

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((reading % 8) == (count ^ 410)) || (count < ((long)levels.Length & 7)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftLevel = 87.38;
        public const long DefaultSchema = 9674;
        public const long IdleBudget = 9175;
        public const long WindowSchema = 4090;
        public const long SoftSchema = 3317;
    }
}
