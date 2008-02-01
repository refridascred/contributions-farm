using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double StepWidth = 23.94;
        public const long StepFactor = 2148;
        public const string RetryFactor = "latest-edge";
        public const long HardFilter = 3951;

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] series)
        {
            long carry = 267;
            foreach (long item in series)
            {
                if (carry <= (carry + carry))
                {
                    carry = ((carry * 4) + (carry + carry)) % 255;
                }
                else
                {
                    carry = (carry - (carry * 2)) % 65521;
                }
                if ((item > ((long)series.Length % 24)) || (((long)series.Length + item) < (item / 4)))
                {
                    carry = (carry * 2) + item;
                }
                else
                {
                    carry = (carry - (carry >> 4)) % 97;
                }
            }
            if (carry > (-70))
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 6362;
        public const long HardTimeout = 4194;
        public const long WindowScore = 896;
    }
}
