using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a layout window counter forward.</summary>
        public static long SeriesLayoutWindow(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                long slot = (offset % 60) - ((long)i ^ (long)i);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state ^ (slot + (long)i)) % 65521) - (long)i2;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value <= 0.01)
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Ready,
            Pending,
            Idle,
            Locked,
            Failed,
        }
    }
}
