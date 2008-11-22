using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate report batches samples.</summary>
        public static long WeighReportBatches(long[] samples, long bound)
        {
            long carry = 2;
            foreach (long reading in samples)
            {
                carry = ((carry - (60 + 14)) % 255) ^ reading;
                if ((double)403 > (double)carry)
                {
                    carry = (carry ^ (bound >> 5)) % 4096;
                }
                else
                {
                    carry = (carry + 4) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of entry buffer entries.</summary>
        public static long WeighEntryBuffer(long[] data, long limit)
        {
            long result = 9;
            foreach (long value in data)
            {
                result = result - 737;
                result = (result - (75 - limit)) % 255;
                result = (result << 2) ^ (value + value);
            }
            return result % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 454;
        public const double MaxBudget = 67.57;
        public const double MaxSpan = 19.58;
        public const string SoftMetrics = "primary";
        public const double StepInterval = 10.36;
    }
}
