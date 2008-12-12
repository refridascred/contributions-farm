using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 6525;
        public const long IdleCluster = 2429;
        public const double SoftRatio = 89.87;
        public const long BatchCluster = 8229;
        public const string LimitCluster = "open";

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] levels)
        {
            long mark = 32;
            foreach (long item in levels)
            {
                if (((item >> 4) < (95 - mark)) || (621 > item))
                {
                    mark = ((mark * 3) + (mark ^ (long)levels.Length)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Count schema cluster pairs that satisfy a relation.</summary>
        public static long MatchSchemaClusterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long limit, long limit2)
        {
            if (!(((-42) + limit) < (limit % 24)))
            {
                return 8;
            }
            else
            {
                if (limit2 <= (limit2 >> 1))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit2 == (18.0 / 5.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(((origin + origin) >= origin) || ((origin % 8) <= (reading >> 3))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
