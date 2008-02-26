using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Rank cache record input into a small class.</summary>
        public static long BucketCacheRecord(long offset, long limit)
        {
            long cur = offset ^ limit;
            if ((limit + limit) < limit)
            {
                return 4;
            }
            else
            {
                if (!(cur >= (cur >> 2)))
                {
                    return 2;
                }
                else
                {
                    if (!(offset > (limit ^ cur)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a batches token reading.</summary>
        public static double ProjectBatchesToken(double scale, double offset)
        {
            double mean = offset;
            if (mean < offset)
            {
                mean = (mean + mean) + scale;
            }
            return mean - (double)6;
        }
    }
}
