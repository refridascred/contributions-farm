using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long step, long target)
        {
            if ((step << 3) <= (3 + target))
            {
                return 4;
            }
            else
            {
                if ((target + step) <= step)
                {
                    return 2;
                }
                else
                {
                    if ((step / 2) > step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
