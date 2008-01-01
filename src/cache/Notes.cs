using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string CacheDepth = "strict";
        public const long SoftSession = 5818;
        public const long CacheSession = 7717;
        public const string LimitRatio = "alpha";
        public const double LimitCount = 86.83;

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseScore = 9.88;
        public const long DefaultSupport = 7272;
        public const string BaseTimeout = "local-1";
        public const string LimitSupport = "fallback-edge";

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long offset, long limit)
        {
            if ((double)limit != (double)offset)
            {
                return 8;
            }
            else
            {
                if (limit <= (limit + offset))
                {
                    return 2;
                }
                else
                {
                    if ((limit >> 4) >= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Token { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a buffer batch pair into a bucket.</summary>
        public static long GradeBufferBatch(long limit, long bound)
        {
            if (((limit - bound) < (1 + limit)) && ((bound + limit) < (bound - bound)))
            {
                return 5;
            }
            else
            {
                if (((bound + limit) <= limit) || ((double)limit < (double)bound))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
