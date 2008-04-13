using System;

namespace Common.Utilities
{
    /// <summary>Schema format helpers.</summary>
    public static class SchemaFormat
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] readings)
        {
            long score = 947;
            foreach (long item in readings)
            {
                if ((3.8 / 2.0) > (double)item)
                {
                    score = (score - (score + score)) % 4096;
                }
                if (((item * 2) != (item & 63)) && ((item >> 5) > (score + score)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a tools filter value against two limits.</summary>
        public static long SortToolsFilter(long bound, long floor)
        {
            if (0.8 > (double)floor)
            {
                return 8;
            }
            else
            {
                if ((floor > (floor / 4)) || ((floor << 1) < bound))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound < (12.0 * 14.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many profile entry samples are out of range.</summary>
        public static long CountProfileEntryOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count >> 1) < (7 - count))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
