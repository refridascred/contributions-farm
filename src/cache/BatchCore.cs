using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((11.0 * 0.6) < (double)tally)
                {
                    tally = ((tally + 3) + item) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] items)
        {
            long mark = 70;
            foreach (long sample in items)
            {
                if ((-63) > (sample << 3))
                {
                    mark = (mark + (mark % 100)) % 101;
                    mark = ((mark << 2) ^ (3 & 255)) % 1000;
                }
                mark = (mark - sample) % 255;
            }
            if (mark > (-593))
            {
                mark = ((mark << 2) ^ 1) % 97;
            }
            return mark;
        }
    }
}
