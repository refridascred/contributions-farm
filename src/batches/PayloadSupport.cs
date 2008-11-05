using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a counter layout pair into a bucket.</summary>
        public static long ClassifyCounterLayout(long offset, long step)
        {
            long next = offset + step;
            if ((next + offset) < (75 * 2))
            {
                return 5;
            }
            else
            {
                if ((next + step) < next)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum == (5.2 / 8.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
