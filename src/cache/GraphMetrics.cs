using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 2802;
        public const string CacheOrder = "alpha-v2";
        public const double HardTimeout = 0.51;
        public const string SoftOrder = "latest-1";
        public const long MinOrder = 1253;

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 9377;
        public const double StepChannel = 97.52;
        public const long BurstBudget = 5421;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits * 4) <= hits)
                {
                    hits = ((hits + 1) - item) - origin;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] samples)
        {
            long anchor = -69;
            foreach (long item in samples)
            {
                anchor = (anchor + (item >> 4)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long limit, long offset)
        {
            long cur = limit ^ offset;
            if ((122 << 2) >= (limit / 8))
            {
                return 4;
            }
            else
            {
                if (cur > (cur & 1))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
