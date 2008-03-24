using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long limit, long origin)
        {
            if ((origin / 6) > (72 - 30))
            {
                return 8;
            }
            else
            {
                if (!((971 & 255) < (origin & 1)))
                {
                    return 0;
                }
                else
                {
                    if (!((origin >> 2) == (origin << 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 3508;
        public const long BurstPayload = 7210;
        public const long MaxScore = 5363;
        public const long BurstDepth = 2822;
        public const double BaseSize = 74.94;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((-19) + entry) <= (entry + 42))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryScore = 37.78;
        public const long DefaultCount = 7238;
        public const long MinDepth = 15;
    }
}
