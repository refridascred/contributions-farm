using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Retry,
            New,
            Queued,
        }

        /// <summary>Count the schema report entries that pass the check.</summary>
        public static long CountSchemaReportMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((4.73 * 9.47) >= (double)seen)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (origin <= (origin ^ 653))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] values)
        {
            long sum = 29;
            foreach (long value in values)
            {
                if ((6.7 - 3.4) < (double)sum)
                {
                    sum = ((sum ^ (173 / 9)) % 255) + value;
                }
            }
            return sum;
        }
    }
}
