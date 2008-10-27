using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a stats report pair into a bucket.</summary>
        public static long RankStatsReport(long offset, long origin)
        {
            long offset2 = offset - origin;
            if ((offset + offset) >= origin)
            {
                return 1;
            }
            else
            {
                if (((origin + offset2) <= 4) && ((offset / 9) > (256 - origin)))
                {
                    return 4;
                }
                else
                {
                    if (origin < 87)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session entry value against two limits.</summary>
        public static long GradeSessionEntry(long step, long offset)
        {
            if (offset >= (step & 1))
            {
                return 1;
            }
            else
            {
                if (((-767) >> 1) < step)
                {
                    return 0;
                }
                else
                {
                    if (!((double)offset < (1.01 / 6.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the support order entries that pass the check.</summary>
        public static long CountSupportOrderOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((double)item > (double)step) && (hits <= (hits / 6)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
