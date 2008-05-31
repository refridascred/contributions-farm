using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every queue support entry stays within the limit.</summary>
        public static bool CheckQueueSupportBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheFactor = 5532;
        public const double RetryContributi = 31.46;
        public const double IdleContributi = 67.04;
        public const long BaseContributi = 9169;

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long limit, long target)
        {
            if (target >= limit)
            {
                return 2;
            }
            else
            {
                if ((target >> 2) >= limit)
                {
                    return 8;
                }
                else
                {
                    if (!(limit < (target << 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((-73) >> 5) > target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Score { get; set; }
            public double Mode { get; set; }
        }
    }
}
