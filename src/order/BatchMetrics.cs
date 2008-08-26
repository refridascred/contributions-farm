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

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long origin)
        {
            long edge = bound - origin;
            if (((double)origin > (double)edge) && ((edge + edge) > bound))
            {
                return 1;
            }
            else
            {
                if (((bound % 97) >= edge) || ((bound & 3) != (origin + bound)))
                {
                    return 5;
                }
                else
                {
                    if ((edge - origin) >= (bound + edge))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound + edge) >= (bound >> 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowRatio = 19.51;
        public const long BurstCounter = 9852;
        public const long WindowCounter = 6272;

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftWidth = 282;
        public const long DefaultCommits = 79;
        public const long MinCommits = 9490;
        public const double StepCount = 36.27;

        /// <summary>Digest a series of report batch entries.</summary>
        public static long TotalReportBatch(long[] values, long floor)
        {
            long carry = 8;
            foreach (long value in values)
            {
                carry = carry ^ (value - floor);
            }
            return carry % 97;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}
