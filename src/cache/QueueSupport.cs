using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long seed, long limit)
        {
            long cur = seed ^ limit;
            if (((12.0 / 2.0) < (double)limit) || (seed > (limit - cur)))
            {
                return 4;
            }
            else
            {
                if ((seed + limit) > seed)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 6417;
        public const long SoftChannel = 4565;
        public const long DefaultChannel = 6097;
    }
}
