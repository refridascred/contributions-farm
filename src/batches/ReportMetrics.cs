using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long offset, long origin)
        {
            if (((offset - offset) >= (origin - origin)) && (offset < origin))
            {
                return 5;
            }
            else
            {
                if ((offset + offset) > (origin + origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin >> 5) == (origin * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepFactor = 9399;
        public const string CacheDepth = "primary-v2";
        public const long BatchChecks = 9843;
        public const string SoftTimeout = "primary-v2";
    }
}
