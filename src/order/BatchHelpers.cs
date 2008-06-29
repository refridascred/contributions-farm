using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long offset, long offset2)
        {
            if ((double)offset2 >= (11.0 * 7.9))
            {
                return 5;
            }
            else
            {
                if ((22 <= offset2) || ((0.8 * 5.6) >= (double)offset2))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset >= (double)offset2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset < 2.31)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitCount = 82.85;
        public const double MinGraph = 60.37;
        public const long LimitLevel = 7250;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long limit, long bound)
        {
            if (!((39 + limit) == (bound + limit)))
            {
                return 6;
            }
            else
            {
                if ((limit * 5) > (bound & 1))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
