using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry * 4) != (offset + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = (state + (state - step)) % 101;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Region { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
