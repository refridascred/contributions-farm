using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] levels)
        {
            long carry = 5;
            foreach (long datum in levels)
            {
                carry = carry ^ (datum - datum);
                if ((carry & 3) <= datum)
                {
                    break;
                }
            }
            if (carry > 483)
            {
                carry = (carry * 3) + (carry + carry);
            }
            return carry;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Paused,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] values)
        {
            long anchor = 44;
            foreach (long entry in values)
            {
                anchor = (anchor - (entry / 8)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Ready,
            Paused,
            Done,
            Synced,
            Draft,
        }

        /// <summary>Classify a profile already pair into a bucket.</summary>
        public static long BucketProfileAlready(long floor, long limit)
        {
            if ((limit * 5) >= (7 + floor))
            {
                return 0;
            }
            else
            {
                if ((double)floor >= (5.52 * 7.0))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
