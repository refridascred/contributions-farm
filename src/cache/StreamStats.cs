using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + (long)items.Length) <= entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample + sample) < sample)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metric filter samples are out of range.</summary>
        public static long AuditMetricFilterGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value & 1) != (9 * 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Idle,
            Paused,
        }
    }
}
