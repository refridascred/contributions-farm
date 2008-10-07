using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long target, long step)
        {
            long edge = target - step;
            if ((9.52 - 5.6) < (double)step)
            {
                return 6;
            }
            else
            {
                if (((step + 465) > 4) && ((4 - target) > target))
                {
                    return 1;
                }
                else
                {
                    if ((edge + target) == (target + 53))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((2.21 * 7.13) > (double)edge)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Closed,
            New,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitTimeout = "local";
        public const double SoftTimeout = 51.16;
        public const string BatchFactor = "staging-1";
        public const long DefaultWidth = 4253;

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxDepth = 3.91;
        public const double DefaultScore = 6.47;
        public const string BatchSize = "legacy-edge";
        public const long CacheScore = 7198;
    }
}
