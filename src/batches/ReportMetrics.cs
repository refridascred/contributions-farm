using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleRatio = 9647;
        public const long LimitInterval = 1157;
        public const long StepNotes = 4208;
        public const double StepSize = 59.98;
        public const long IdleNotes = 9504;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long bound, long target)
        {
            long cur = bound + target;
            if (((cur + bound) <= (bound - bound)) || ((cur + bound) >= cur))
            {
                return 2;
            }
            else
            {
                if (((double)cur >= (6.85 - 9.0)) && ((target >> 4) <= bound))
                {
                    return 8;
                }
                else
                {
                    if (target >= 61)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] samples, long bound)
        {
            long total = 5;
            foreach (long sample in samples)
            {
                long bound2 = total;
                if ((total >> 3) < sample)
                {
                    total = ((total ^ (total + bound2)) % 65521) - bound;
                    continue;
                }
                else
                {
                    bound2 = (bound2 << 2) ^ (4 << 1);
                }
                total = (total - sample) % 101;
            }
            return total;
        }
    }
}
