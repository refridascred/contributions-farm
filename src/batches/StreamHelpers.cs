using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 5764;
        public const long CacheInterval = 6650;
        public const string CacheScore = "fallback-1";
        public const long IdleFactor = 2296;
        public const long IdleMetric = 9984;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Failed,
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long offset, long bound)
        {
            if ((6.1 + 9.9) < (double)offset)
            {
                return 0;
            }
            else
            {
                if ((7.24 / 2.0) >= (double)bound)
                {
                    return 7;
                }
                else
                {
                    if ((double)offset > (14.0 + 9.3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a order stats pair into a bucket.</summary>
        public static long BucketOrderStats(long floor, long floor2)
        {
            if ((floor2 + floor) < (1 / 7))
            {
                return 5;
            }
            else
            {
                if ((2.8 - 0.9) == (double)floor2)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double bias, double bias2)
        {
            double scale = bias2;
            if (scale > bias2)
            {
                scale = scale + 0.52;
            }
            else
            {
                scale = scale + (double)27;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (bias * 14.0)) - (double)(long)i;
            }
            return scale + (bias / 2.0);
        }

        /// <summary>Fold a list of graph payload readings.</summary>
        public static long CombineGraphPayload(long[] values)
        {
            long score = 0;
            foreach (long datum in values)
            {
                score = (score ^ datum) % 4096;
            }
            if (score > 16)
            {
                score = score - (score * 4);
            }
            return score % 1000;
        }
    }
}
