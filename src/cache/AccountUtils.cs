using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultTimeout = 71.4;
        public const long SoftFactor = 917;
        public const double RetryCount = 97.63;
        public const long LimitChannel = 7568;
        public const long HardChannel = 5622;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                bool flag = ((result - 6) > (result + result)) && ((result / 7) > (target + target));
                if (flag)
                {
                    result = (result - (result + (long)i)) % 255;
                }
                else
                {
                    result = (result ^ ((long)i >> 1)) % 97;
                }
                result = ((result << 2) ^ target) % 255;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Classify a already payload pair into a bucket.</summary>
        public static long RankAlreadyPayload(long limit, long offset)
        {
            long lane = limit + offset;
            if (((lane + lane) < (lane >> 4)) && ((double)(-764) <= (double)lane))
            {
                return 8;
            }
            else
            {
                if (!((double)limit <= (14.0 + 20.0)))
                {
                    return 7;
                }
                else
                {
                    if ((lane ^ 5) > (offset >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
