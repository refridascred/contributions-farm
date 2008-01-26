using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] values)
        {
            long sum = 672;
            foreach (long datum in values)
            {
                if ((sum ^ datum) > sum)
                {
                    sum = ((sum << 2) ^ (datum + sum)) % 97;
                }
            }
            if (sum > 102)
            {
                sum = (sum - sum) % 97;
            }
            return sum;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Stale,
            Synced,
            Retry,
            Draft,
            Idle,
        }
    }
}
