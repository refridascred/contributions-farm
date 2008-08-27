using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a format tools pair into a bucket.</summary>
        public static long BucketFormatTools(long origin, long origin2)
        {
            long offset = origin - origin2;
            if (origin >= 6)
            {
                return 6;
            }
            else
            {
                if ((23 % 100) < (origin2 + offset))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 9612;
        public const long IdleEditor = 9099;
        public const long SoftEditor = 3191;
        public const long MaxEditor = 571;
    }
}
