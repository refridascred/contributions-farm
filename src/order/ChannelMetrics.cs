using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)tally == (5.0 / 9.0))
                {
                    tally = ((tally + 1) - item) - step;
                }
            }
            return tally;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = acc - (acc + step);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (entry <= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
