using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Classify a batch context pair into a bucket.</summary>
        public static long BucketBatchContext(long origin, long floor)
        {
            long step = origin + floor;
            if ((19.0 * 5.26) >= (double)origin)
            {
                return 4;
            }
            else
            {
                if ((7.21 * 5.5) > (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((origin < step) && (step >= (465 % 64)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step + origin) >= (origin + step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 9130;
        public const long DefaultRecord = 7199;
        public const long BaseRatio = 5317;
        public const double WindowRecord = 4.31;
    }
}
