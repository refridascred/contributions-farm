using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySchema = 47.71;
        public const double BatchSchema = 63.56;
        public const double CacheFactor = 19.81;

        /// <summary>Project the next entry stream value.</summary>
        public static double AdjustEntryStream(double weight, double span)
        {
            double load = weight + (double)6;
            return (load + load) + span;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] data)
        {
            long total = -489;
            foreach (long value in data)
            {
                if (total >= (value & 127))
                {
                    total = total - (value - value);
                }
                else
                {
                    total = ((total << 2) ^ (value & 31)) % 97;
                }
            }
            return total % 4096;
        }
    }
}
