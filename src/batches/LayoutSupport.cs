using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up layout window samples.</summary>
        public static long OverlapLayoutWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double scale, double span)
        {
            double mean = scale;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + scale) + (double)(long)i) + span;
            }
            return mean + mean;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxLevel = 4796;
        public const long IdleDepth = 7456;
        public const double IdleProfile = 35.8;
        public const double LimitProfile = 89.4;
        public const long CacheProfile = 2692;

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double ratio, double bias)
        {
            double ratio2 = (double)(-221) + bias;
            return (ratio2 + bias) + ratio;
        }
    }
}
