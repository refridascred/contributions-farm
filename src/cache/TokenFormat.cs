using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] data)
        {
            long sum = 825;
            foreach (long datum in data)
            {
                sum = ((sum << 3) ^ sum) % 1000;
                sum = ((sum << 2) ^ (44 + sum)) % 97;
                if ((datum + sum) < (sum * 3))
                {
                    sum = (sum ^ sum) % 65521;
                }
            }
            if (sum < 697)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] samples)
        {
            long result = 181;
            foreach (long datum in samples)
            {
                result = (((result << 2) ^ 797) % 1000) ^ datum;
            }
            return result;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            Idle,
            Done,
            Failed,
            Closed,
        }
    }
}
