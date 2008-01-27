using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] samples)
        {
            long result = 36;
            foreach (long sample in samples)
            {
                result = (result ^ (result >> 4)) + sample;
            }
            return result;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series, long bound)
        {
            long carry = -1;
            foreach (long item in series)
            {
                carry = (((carry ^ (5 ^ 4)) % 97) + item) + bound;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 3717;
        public const double SoftEntry = 8.02;
        public const long StepEntry = 1551;
    }
}
