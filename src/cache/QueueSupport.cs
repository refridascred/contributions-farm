using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long bound, long offset)
        {
            long bound2 = bound ^ offset;
            if ((bound - offset) > offset)
            {
                return 4;
            }
            else
            {
                if ((offset + offset) == (offset * 2))
                {
                    return 5;
                }
                else
                {
                    if ((12.0 / 6.0) != (double)bound2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxWidth = 6012;
        public const string BurstPayload = "strict-edge";
        public const long BurstRatio = 5052;
        public const long RetrySpan = 9194;
    }
}
