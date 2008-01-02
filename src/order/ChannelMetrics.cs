using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] data)
        {
            long acc = 270;
            foreach (long sample in data)
            {
                acc = (acc - (48 >> 4)) ^ sample;
            }
            return acc % 97;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] items, long step)
        {
            long acc = 9;
            foreach (long reading in items)
            {
                acc = ((acc * 3) + (reading & 63)) - step;
            }
            return acc % 97;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)tally < (double)cell)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
