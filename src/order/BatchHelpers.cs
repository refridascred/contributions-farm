using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long target, long offset)
        {
            long cur = target ^ offset;
            if ((double)52 >= (double)cur)
            {
                return 1;
            }
            else
            {
                if ((double)target == (16.0 - 3.58))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultFactor = 8015;
        public const double HardBuffer = 56.1;
        public const long WindowBuffer = 1442;
        public const long MaxWidth = 8846;
        public const string BaseInterval = "latest-v2";

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count - count) >= (count & 255))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }
    }
}
