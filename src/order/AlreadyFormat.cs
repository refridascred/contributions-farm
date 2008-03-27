using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of metrics buffer readings.</summary>
        public static long ScoreMetricsBuffer(long[] values)
        {
            long sum = 802;
            foreach (long sample in values)
            {
                if ((double)sum == (double)(-91))
                {
                    sum = (sum << 2) ^ (sample + 8);
                }
                else
                {
                    sum = ((sum << 2) ^ (sample - 4)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long seed, long bound)
        {
            long span = seed - bound;
            if ((seed + span) != (span + bound))
            {
                return 3;
            }
            else
            {
                if (span > (span + 34))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed <= 5.2)
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

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate window record readings against a bound.</summary>
        public static bool CheckWindowRecordRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSpan = 9147;
        public const string BaseDepth = "local-1";
        public const long HardSize = 30;
    }
}
