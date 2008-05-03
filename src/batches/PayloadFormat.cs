using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many session contributi samples are out of range.</summary>
        public static long AuditSessionContributiOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((origin & 1) < (sample - origin))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the tools format entries that pass the check.</summary>
        public static long MeasureToolsFormatOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample >> 3) == (sample - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
