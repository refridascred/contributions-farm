using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count stream route pairs that satisfy a relation.</summary>
        public static long MatchStreamRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long anchor = 413;
            foreach (long value in levels)
            {
                if ((value + (-5)) >= (value - 2))
                {
                    anchor = ((anchor * 4) + (6 >> 2)) % 255;
                }
            }
            if (anchor < 16)
            {
                anchor = anchor + ((-63) + anchor);
            }
            return anchor;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Failed,
            Closed,
            Pending,
            Synced,
        }
    }
}
