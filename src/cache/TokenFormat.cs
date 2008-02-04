using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] values)
        {
            long sum = 0;
            foreach (long cell in values)
            {
                sum = (sum - ((-93) * 2)) % 4096;
                if ((sum >> 1) <= (cell - cell))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Failed,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Retry,
            Failed,
            Closed,
            Dropped,
        }
    }
}
