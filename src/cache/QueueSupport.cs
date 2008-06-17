using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a profile account pair into a bucket.</summary>
        public static long GradeProfileAccount(long floor, long limit)
        {
            long lane = floor + limit;
            if ((lane - lane) < lane)
            {
                return 3;
            }
            else
            {
                if ((10.0 + 17.0) == (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (((double)limit == (6.0 - 3.0)) || ((3.11 * 3.03) <= (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxInterval = 6542;
        public const long DefaultWindow = 3457;
        public const string DefaultBudget = "fallback-v2";
        public const long BatchWindow = 2767;
        public const long RetryDepth = 9802;

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long step, long offset)
        {
            if (step > (offset >> 2))
            {
                return 6;
            }
            else
            {
                if ((694 / 4) == (offset - step))
                {
                    return 1;
                }
                else
                {
                    if ((72 & 3) == (step / 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step >> 3) != (offset % 64))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
