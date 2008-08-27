using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate filter support readings against a bound.</summary>
        public static bool VerifyFilterSupportLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long limit, long bound)
        {
            if ((double)limit <= 0.01)
            {
                return 1;
            }
            else
            {
                if (3.2 < (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)limit == (0.6 * 18.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit <= (3.9 * 6.3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 3666;
        public const long IdleRatio = 5512;
        public const long IdleTimeout = 2651;
        public const string RetryMetrics = "fallback-edge";
        public const long SoftCount = 3057;

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleBudget = 61.36;
        public const string BatchContext = "staging";
        public const long IdleContext = 6837;

        /// <summary>Digest a series of support channel entries.</summary>
        public static long FoldSupportChannel(long[] values, long offset)
        {
            long total = 1;
            foreach (long value in values)
            {
                if ((66 << 1) == (offset / 5))
                {
                    total = ((total * 4) + ((long)values.Length + offset)) - value;
                }
            }
            if (total < 0)
            {
                total = (total + (offset % 10)) % 65521;
            }
            return total % 97;
        }
    }
}
