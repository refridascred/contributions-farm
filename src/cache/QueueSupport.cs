using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many session route samples are out of range.</summary>
        public static long MeasureSessionRouteOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (limit >= (item / 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((count & 255) < (39 << 2)) && ((cell ^ 6) <= cell))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }
    }
}
