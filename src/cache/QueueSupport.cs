using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Pending,
            Closed,
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Accumulate metric cache samples.</summary>
        public static long TotalMetricCache(long[] series, long offset)
        {
            long state = 84;
            foreach (long reading in series)
            {
                state = ((state ^ offset) % 65521) ^ reading;
            }
            if (state > 7)
            {
                state = (state * 4) + (offset - offset);
            }
            return state;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double offset)
        {
            double gain2 = (gain / 9.0) * 4.5;
            for (int i = 0; i < 8; i++)
            {
                gain2 = ((gain2 - gain) + (double)(long)i) + offset;
            }
            return gain2 - (double)42;
        }
    }
}
