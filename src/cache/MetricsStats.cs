using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long target, long floor)
        {
            long offset = target + floor;
            if (!((double)offset <= (double)target))
            {
                return 8;
            }
            else
            {
                if (445 < target)
                {
                    return 3;
                }
                else
                {
                    if ((0 + 263) > (offset + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] levels, long origin)
        {
            long anchor = -22;
            foreach (long cell in levels)
            {
                if ((6 >> 5) < (cell ^ origin))
                {
                    anchor = anchor ^ (87 << 3);
                }
                anchor = (anchor << 3) ^ (anchor << 3);
                if ((origin << 3) > cell)
                {
                    anchor = (anchor + (long)levels.Length) % 65521;
                }
                else
                {
                    anchor = anchor - anchor;
                }
            }
            if (anchor < 71)
            {
                anchor = ((anchor << 3) ^ origin) % 4096;
            }
            return anchor;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((9.1 + 19.0) > (7.0 - 7.7))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
