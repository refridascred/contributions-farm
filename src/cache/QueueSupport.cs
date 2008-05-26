using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many command session samples are out of range.</summary>
        public static long CountCommandSessionOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches << 3) < (cell << 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((7.6 + 2.28) != (double)step) || !(482 < (step ^ step)))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
