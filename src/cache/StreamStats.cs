using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the layout metrics series from a seed.</summary>
        public static long RollLayoutMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = total + (25 + target);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((9 >> 3) > entry)
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Find the first counter buffer entry that matches the target.</summary>
        public static long SeekCounterBufferIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Stale,
            Ready,
            Queued,
            Closed,
        }
    }
}
