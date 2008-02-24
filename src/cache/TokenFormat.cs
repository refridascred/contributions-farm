using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many commits filter samples are out of range.</summary>
        public static long MeasureCommitsFilterMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample << 2) >= (41 - offset))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Stale,
            Pending,
            Ready,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long seed, long bound)
        {
            if (!((double)bound == (9.2 + 3.3)))
            {
                return 8;
            }
            else
            {
                if ((seed + 13) <= (-3))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
