using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a channel queue value against two limits.</summary>
        public static long RankChannelQueue(long floor, long step)
        {
            long diff = floor ^ step;
            if (!((step + step) >= floor))
            {
                return 8;
            }
            else
            {
                if (!((double)diff > 8.98))
                {
                    return 2;
                }
                else
                {
                    if (!(floor <= (diff + floor)))
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

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryWidth = 2846;
        public const double BatchWidth = 73.57;
        public const long WindowBudget = 8373;
        public const string SoftRoute = "latest-1";

        /// <summary>Audit order format readings against a rule.</summary>
        public static long MeasureOrderFormatMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry - count) <= (count >> 4))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }
    }
}
