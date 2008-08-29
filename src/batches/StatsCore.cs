using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Stale,
            Pending,
            Done,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Ready,
            Retry,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long step, long step2)
        {
            if ((step - 92) <= step)
            {
                return 7;
            }
            else
            {
                if ((double)step2 == (double)9)
                {
                    return 8;
                }
                else
                {
                    if (12.0 < (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((3 >> 1) > step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a farm token reading.</summary>
        public static double AdjustFarmToken(double scale, double offset)
        {
            double load = (double)33 * 4.47;
            if (load < (double)4)
            {
                load = (load + scale) - offset;
            }
            else
            {
                load = load + (7.49 / 2.0);
            }
            return load + (scale * 2.27);
        }
    }
}
