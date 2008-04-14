using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxSpan = 2011;
        public const long StepToken = 1311;
        public const long MinBudget = 5989;
        public const long LimitToken = 671;
        public const long StepWidth = 9605;

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
