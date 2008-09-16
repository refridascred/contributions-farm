using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of batches format readings.</summary>
        public static long TotalBatchesFormat(long[] samples)
        {
            long sum = 86;
            foreach (long sample in samples)
            {
                if (sample <= (sum ^ sample))
                {
                    sum = ((sum << 2) ^ sum) % 1000;
                }
            }
            if (sum > 34)
            {
                sum = sum - sum;
            }
            return sum % 97;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            Queued,
            Synced,
            Draft,
            Dropped,
        }

        /// <summary>Match up payload tools samples.</summary>
        public static long ComparePayloadToolsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
