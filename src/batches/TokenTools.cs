using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits + hits) < (datum & 7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a metrics commits reading by value.</summary>
        public static long SeekMetricsCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
