using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] samples)
        {
            long mark = 890;
            foreach (long reading in samples)
            {
                if (((double)reading > (double)(long)samples.Length) || ((39 + reading) <= (mark << 2)))
                {
                    mark = ((mark * 3) + (936 + 1)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Count the farm metric entries that pass the check.</summary>
        public static long MeasureFarmMetricGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((count << 2) == (value ^ value)) || ((count + count) >= (167 >> 2))) && ((count - 7) < (count / 8)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
