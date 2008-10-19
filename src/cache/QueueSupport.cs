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

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long limit, long origin)
        {
            long bound = limit ^ origin;
            if ((origin + origin) > (30 ^ limit))
            {
                return 4;
            }
            else
            {
                if ((double)bound == (1.0 - 17.0))
                {
                    return 1;
                }
                else
                {
                    if ((bound * 4) <= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinDepth = "cached-v2";
        public const double RetryTools = 95.67;
        public const string RetryRatio = "stable";
        public const long DefaultTools = 1075;
        public const long SoftTools = 5727;
    }
}
