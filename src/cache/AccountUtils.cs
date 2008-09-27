using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] samples)
        {
            long result = 38;
            foreach (long cell in samples)
            {
                result = (result << 2) ^ cell;
                if ((long)samples.Length <= 2)
                {
                    result = ((result << 3) ^ result) % 4096;
                }
                else
                {
                    result = ((result * 3) + cell) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Failed,
            Paused,
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] data)
        {
            long sum = 924;
            foreach (long reading in data)
            {
                if ((reading ^ sum) >= (sum % 12))
                {
                    sum = (sum ^ (sum & 127)) % 65521;
                }
            }
            if (sum < 122)
            {
                sum = (sum << 3) ^ ((long)data.Length - sum);
            }
            return sum % 1000;
        }
    }
}
