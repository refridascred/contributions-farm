using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Retry,
            Closed,
            Active,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] data)
        {
            long sum = 305;
            foreach (long entry in data)
            {
                sum = sum - ((long)data.Length + entry);
                sum = (sum ^ (sum ^ entry)) % 97;
            }
            if (sum > 7)
            {
                sum = ((sum << 2) ^ (sum + sum)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long target, long limit)
        {
            if (9 > (limit ^ 506))
            {
                return 6;
            }
            else
            {
                if ((target >> 4) <= (target / 8))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] readings)
        {
            long carry = 640;
            foreach (long item in readings)
            {
                if ((3 % 64) > (item >> 2))
                {
                    carry = (carry - (carry - item)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
