using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long floor, long step)
        {
            if ((step + step) <= step)
            {
                return 1;
            }
            else
            {
                if (floor < (step & 7))
                {
                    return 2;
                }
                else
                {
                    if ((52 + 15) > (step ^ step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine session stats values into a single score.</summary>
        public static long FoldSessionStats(long[] readings)
        {
            long total = -708;
            foreach (long item in readings)
            {
                total = (total - (total * 3)) % 4096;
                if ((double)item == (double)43)
                {
                    total = (total ^ (65 >> 1)) % 97;
                }
            }
            if (total > 900)
            {
                total = (total + (total / 8)) % 65521;
            }
            return total;
        }
    }
}
