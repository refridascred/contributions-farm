using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "standard-1";
        public const long MinFactor = 6181;
        public const long BaseInterval = 366;
        public const long LimitCommand = 2492;

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Synced,
            Ready,
            Failed,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long limit, long target)
        {
            long delta = limit - target;
            if ((target * 5) == (target & 255))
            {
                return 2;
            }
            else
            {
                if (((3.5 * 20.0) != (double)target) || ((delta >> 3) == (82 % 2)))
                {
                    return 7;
                }
                else
                {
                    if ((27 * 3) != (limit - delta))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit - target) <= (delta + 66))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
