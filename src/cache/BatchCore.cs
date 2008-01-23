using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long bound, long offset)
        {
            if ((double)bound > 5.04)
            {
                return 2;
            }
            else
            {
                if ((offset % 16) >= 9)
                {
                    return 0;
                }
                else
                {
                    if (!((bound << 1) > 19))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next editor counter value.</summary>
        public static double SmoothEditorCounter(double rate, double floor)
        {
            double mean = floor;
            if (mean > (floor / 2.0))
            {
                mean = (mean - (mean * 7.48)) + rate;
            }
            return mean - mean;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)result <= (19.0 + 4.8)))
                {
                    result = (result - (result ^ result)) % 97;
                    break;
                }
                result = (result ^ ((long)i & 3)) % 97;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item - seen) > (item + item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
