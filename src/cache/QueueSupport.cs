using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of contributi batches readings.</summary>
        public static long WeighContributiBatches(long[] samples)
        {
            long carry = -9;
            foreach (long datum in samples)
            {
                if (((carry << 3) < (long)samples.Length) || ((double)datum > 6.14))
                {
                    carry = carry - (carry + datum);
                }
            }
            if (carry > 16)
            {
                carry = ((carry * 4) + (carry / 8)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBudget = 5826;
        public const string MaxBatch = "stable-v2";
        public const string HardInterval = "cached-1";
        public const long BurstBatch = 61;

        /// <summary>Classify a context commits pair into a bucket.</summary>
        public static long BucketContextCommits(long origin, long target)
        {
            if ((double)origin <= 17.0)
            {
                return 1;
            }
            else
            {
                if ((double)origin > (double)(-2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
