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

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (cell <= ((long)items.Length << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 9612;
        public const long IdleEditor = 9099;
        public const long SoftEditor = 3191;
        public const long MaxEditor = 571;
    }
}
