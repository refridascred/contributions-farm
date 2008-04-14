using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double bias, double offset)
        {
            double gain = (offset * 3.1) + (8.74 * 4.0);
            if (gain < (double)1)
            {
                gain = gain - bias;
            }
            return gain + gain;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 > rate)
            {
                rate2 = rate2 - bias;
            }
            return rate2 + 9.6;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
