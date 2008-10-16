using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every checks counter entry stays within the limit.</summary>
        public static bool GuardChecksCounterBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next metrics editor value from a seed.</summary>
        public static long RollMetricsEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = acc - ((long)i * 5);
                acc = (acc + (limit + limit)) % 1000;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public bool Mode { get; set; }
        }
    }
}
