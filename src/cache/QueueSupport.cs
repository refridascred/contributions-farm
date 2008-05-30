using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (seed > (item % 10))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((5.4 * 3.3) >= (double)sample)
                {
                    count = (count + 3) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Done,
            Queued,
        }
    }
}
