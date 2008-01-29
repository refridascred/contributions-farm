using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Paused,
            New,
            Closed,
            Queued,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long bound, long limit)
        {
            if ((double)bound <= (14.0 - 8.3))
            {
                return 7;
            }
            else
            {
                if (limit >= bound)
                {
                    return 0;
                }
                else
                {
                    if (((bound & 31) == (limit + limit)) && ((5.15 - 4.7) != (double)limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseFactor = 1217;
        public const long CacheAlready = 9349;
        public const string HardLevel = "staging-edge";
        public const long BurstAlready = 3185;
        public const long CacheSpan = 7077;
    }
}
