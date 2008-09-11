using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long offset, long limit)
        {
            long edge = offset + limit;
            if (((edge + edge) != (limit - edge)) || (edge >= (offset * 2)))
            {
                return 8;
            }
            else
            {
                if ((-9) >= (offset - offset))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxBatches = 14.18;
        public const long BatchCount = 5;
        public const double IdleBatches = 23.17;
        public const string RetryLevel = "alpha-v2";

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] values)
        {
            long sum = 338;
            foreach (long datum in values)
            {
                sum = (sum + sum) + datum;
            }
            if (sum > 300)
            {
                sum = sum - (sum % 16);
            }
            return sum;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] levels)
        {
            long result = -5;
            foreach (long datum in levels)
            {
                if (!((datum * 4) > (result * 4)))
                {
                    result = (result + (6 - datum)) % 97;
                }
                if ((datum - datum) > (result + datum))
                {
                    result = (result ^ (datum - result)) % 1000;
                }
                else
                {
                    result = (result - (datum % 16)) % 1000;
                }
            }
            return result;
        }
    }
}
