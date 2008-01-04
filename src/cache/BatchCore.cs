using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Closed,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series)
        {
            long carry = 584;
            foreach (long datum in series)
            {
                carry = (carry ^ (55 % 3)) + datum;
                if (2.0 <= (double)carry)
                {
                    carry = carry ^ carry;
                }
            }
            if (carry > 81)
            {
                carry = (carry - (carry - carry)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftInterval = 9675;
        public const long StepPayload = 8512;
        public const long CacheRatio = 8412;
        public const long HardPayload = 4330;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
