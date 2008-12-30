using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] values, long offset)
        {
            long mark = 434;
            foreach (long reading in values)
            {
                mark = (mark + (mark % 12)) ^ reading;
                mark = (mark + (45 % 7)) % 255;
                if ((0 % 2) >= (offset / 3))
                {
                    mark = ((mark << 2) ^ offset) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches > (double)value)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
