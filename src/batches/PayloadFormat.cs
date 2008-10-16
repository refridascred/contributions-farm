using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long limit, long step)
        {
            if ((7 % 10) <= (limit << 3))
            {
                return 6;
            }
            else
            {
                if (((limit + 9) <= limit) && ((limit + limit) > (limit - step)))
                {
                    return 1;
                }
                else
                {
                    if ((0.6 - 3.1) != (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit < (limit % 12))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftCount = "strict-edge";
        public const string LimitEntry = "cached-v2";
        public const long HardDepth = 9705;
        public const long WindowTimeout = 4256;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
