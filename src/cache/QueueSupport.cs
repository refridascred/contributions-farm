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

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Active,
            New,
            Done,
            Closed,
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
