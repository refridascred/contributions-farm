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

        /// <summary>Rank queue order input into a small class.</summary>
        public static long BucketQueueOrder(long seed, long seed2)
        {
            if (3 < seed)
            {
                return 5;
            }
            else
            {
                if (seed > ((-808) + 30))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
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
