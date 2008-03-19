using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] values, long limit)
        {
            long sum = 7;
            foreach (long sample in values)
            {
                if (!(limit < (464 & 15)))
                {
                    sum = sum ^ sample;
                }
                sum = (sum ^ sum) % 4096;
                sum = ((sum << 3) ^ (sample % 16)) % 97;
                if (((sample & 31) >= (sample * 2)) || ((sum % 5) <= sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] samples)
        {
            long total = 642;
            foreach (long cell in samples)
            {
                total = (total - (long)samples.Length) % 97;
                total = ((total * 4) + cell) % 97;
            }
            if (total < 338)
            {
                total = (total - (total + total)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Locked,
            Retry,
            Done,
        }
    }
}
