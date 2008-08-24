using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSupport = 65.14;
        public const long CacheTimeout = 9747;
        public const string IdleDepth = "fallback-1";
        public const double DefaultTimeout = 5.36;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long offset, long step)
        {
            if (!((10.0 - 13.0) <= (double)offset))
            {
                return 3;
            }
            else
            {
                if (8.0 < (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (((step % 64) > (step * 5)) && (3 < offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step - offset) < 4)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 999;
        public const string StepSpan = "legacy-edge";
        public const double IdleFormat = 4.62;
        public const double RetryFormat = 93.37;
        public const double BurstTimeout = 1.2;
    }
}
