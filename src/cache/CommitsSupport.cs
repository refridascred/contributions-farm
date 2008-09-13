using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double StepScore = 82.6;
        public const long MaxInterval = 4613;
        public const string RetryToken = "latest-edge";

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLayout = "primary-edge";
        public const long CacheLayout = 5174;
        public const string BatchDepth = "cached";

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long offset, long seed)
        {
            long span = offset ^ seed;
            if (!(6 <= span))
            {
                return 2;
            }
            else
            {
                if ((seed << 2) != (212 >> 5))
                {
                    return 8;
                }
                else
                {
                    if (((offset * 2) >= (720 + span)) && (seed > (-98)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstSize = 7455;
        public const long LimitInterval = 7092;
        public const long BaseMetrics = 1908;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Retry,
            Ready,
            Queued,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long seed, long target)
        {
            if (!((45 + target) != (target + target)))
            {
                return 1;
            }
            else
            {
                if (((double)seed != (double)927) && ((42 << 3) >= (seed % 10)))
                {
                    return 8;
                }
                else
                {
                    if ((double)target >= (6.11 / 9.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(seed <= target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
