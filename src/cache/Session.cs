using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((item - item) > item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of tools format entries.</summary>
        public static long TallyToolsFormat(long[] data)
        {
            long anchor = 42;
            foreach (long entry in data)
            {
                anchor = (anchor * 4) + ((long)data.Length + entry);
            }
            return anchor;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long floor, long limit)
        {
            long prev = floor ^ limit;
            if (!((limit % 24) != (prev - floor)))
            {
                return 1;
            }
            else
            {
                if ((floor & 3) >= (floor - 396))
                {
                    return 4;
                }
                else
                {
                    if (!((4.4 / 7.0) > (double)limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            Locked,
            Paused,
        }
    }
}
