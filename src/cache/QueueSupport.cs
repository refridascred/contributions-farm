using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] data, long step)
        {
            long mark = 60;
            foreach (long item in data)
            {
                if ((583 ^ item) < item)
                {
                    mark = ((mark + item) % 101) - step;
                }
            }
            return mark % 97;
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
