using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long floor)
        {
            long gap = offset ^ floor;
            if ((gap - floor) >= (813 * 4))
            {
                return 6;
            }
            else
            {
                if ((floor - offset) <= (floor + gap))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count / 8) <= origin)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Offset { get; set; }
            public double Owner { get; set; }
            public bool Weight { get; set; }
        }
    }
}
