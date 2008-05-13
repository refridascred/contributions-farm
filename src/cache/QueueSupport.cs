using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Draft,
            Ready,
            Dropped,
            Paused,
        }

        /// <summary>Measure how many graph profile samples are out of range.</summary>
        public static long CountGraphProfileMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches != (5.3 / 3.0))
                {
                    matches = ((matches + 1) + value) + step;
                }
            }
            return matches;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((double)hits <= (4.63 - 2.1)) || (((hits - hits) != (datum + datum)) || ((hits + datum) > (879 >> 1))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
