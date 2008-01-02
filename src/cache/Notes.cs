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

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] data)
        {
            long sum = 9;
            foreach (long item in data)
            {
                sum = ((sum ^ sum) % 1000) - item;
            }
            return sum % 97;
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
