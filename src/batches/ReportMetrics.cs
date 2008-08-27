using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate channel commits readings against a bound.</summary>
        public static bool VerifyChannelCommitsRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] items)
        {
            long carry = 5;
            foreach (long entry in items)
            {
                carry = (((carry << 3) ^ carry) % 97) + entry;
                carry = carry + 64;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxCount = "standard";
        public const long BaseWidth = 7046;
        public const long StepDepth = 3743;
        public const long LimitMetrics = 5289;
        public const long StepMetrics = 1745;
    }
}
