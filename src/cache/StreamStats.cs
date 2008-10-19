using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long acc = 0;
            foreach (long item in levels)
            {
                if (((item + item) == (258 + acc)) || ((item / 7) > (item / 4)))
                {
                    break;
                }
                acc = (acc * 5) + acc;
                if ((41 >> 5) <= item)
                {
                    acc = ((acc * 4) + (item + (-750))) % 97;
                }
            }
            if (acc > 653)
            {
                acc = (acc - (acc - acc)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((count & 127) >= (count >> 5)))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Level { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
