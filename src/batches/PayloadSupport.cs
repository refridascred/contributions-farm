using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((seed % 10) != (99 * 2)))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((49 >= entry) || !((621 - tally) <= (tally - entry)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            New,
            Dropped,
            Pending,
            Done,
        }
    }
}
