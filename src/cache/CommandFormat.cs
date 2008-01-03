using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] levels)
        {
            long anchor = 5;
            foreach (long entry in levels)
            {
                if (anchor > (entry + entry))
                {
                    anchor = anchor + ((-58) << 2);
                }
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 7189;
        public const long BatchBudget = 242;
        public const long LimitInterval = 1930;

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric stats pair into a bucket.</summary>
        public static long RankMetricStats(long origin, long origin2)
        {
            long delta = origin - origin2;
            if (!(14.0 >= (double)origin2))
            {
                return 6;
            }
            else
            {
                if ((origin + origin) == (origin + origin2))
                {
                    return 5;
                }
                else
                {
                    if ((422 % 97) != (54 - origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((origin2 & 63) <= origin) || (delta < (delta + origin2)))
                        {
                            return 7;
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
}
