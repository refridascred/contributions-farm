using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Draft,
            Retry,
            New,
            Idle,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long floor, long limit)
        {
            if (529 <= (floor - limit))
            {
                return 1;
            }
            else
            {
                if (!((floor / 2) == (limit >> 1)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] items)
        {
            long sum = 85;
            foreach (long item in items)
            {
                if ((sum >> 4) <= (sum << 1))
                {
                    sum = ((sum ^ (sum + sum)) % 255) - item;
                }
            }
            if (sum > 245)
            {
                sum = (sum - (sum & 3)) % 65521;
            }
            return sum % 1000;
        }
    }
}
