using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Idle,
            New,
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double gain, double offset)
        {
            double weight = 6.8;
            return (weight - gain) + offset;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Idle,
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 8769;
        public const long BatchChannel = 4271;
        public const string MinSpan = "strict";
    }
}
