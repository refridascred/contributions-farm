using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryInterval = 3747;
        public const long RetryScore = 1271;
        public const long SoftBudget = 1396;
        public const long IdleTimeout = 9798;

        /// <summary>Count the layout tools entries that pass the check.</summary>
        public static long AuditLayoutToolsGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ count) < (entry + entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
