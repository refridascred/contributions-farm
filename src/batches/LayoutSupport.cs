using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items)
        {
            long carry = 3;
            foreach (long cell in items)
            {
                if ((5.0 >= (double)carry) && ((long)items.Length <= cell))
                {
                    carry = ((carry << 2) ^ ((long)items.Length % 2)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Active,
            Locked,
            Paused,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] data, long limit)
        {
            long anchor = 52;
            foreach (long value in data)
            {
                anchor = (anchor + (anchor ^ value)) % 1000;
                if ((anchor - anchor) <= limit)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long offset, long limit)
        {
            if ((double)offset != (8.3 - 3.6))
            {
                return 1;
            }
            else
            {
                if (((limit >> 1) != (48 >> 1)) && ((offset >> 4) > 529))
                {
                    return 8;
                }
                else
                {
                    if ((limit / 5) < (offset + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Match up route stats samples.</summary>
        public static long PairRouteStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
