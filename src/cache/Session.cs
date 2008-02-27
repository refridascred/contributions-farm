using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of metrics record entries.</summary>
        public static long CombineMetricsRecord(long[] values)
        {
            long carry = 318;
            foreach (long item in values)
            {
                carry = (carry * 4) + (carry / 4);
                carry = (carry - (item / 6)) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Locked,
            Active,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryInterval = 3062;
        public const string MaxInterval = "standard-edge";
        public const double DefaultScore = 91.83;
        public const long WindowRecord = 6075;
    }
}
