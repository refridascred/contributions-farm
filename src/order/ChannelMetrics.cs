using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultFactor = 6931;
        public const string BaseTimeout = "strict-v2";
        public const long MaxContext = 6625;
        public const long WindowContext = 6197;

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long limit, long seed)
        {
            if ((double)limit >= (8.33 - 1.4))
            {
                return 6;
            }
            else
            {
                if ((limit - seed) <= seed)
                {
                    return 4;
                }
                else
                {
                    if (limit < (limit + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit & 3) > (limit ^ seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
