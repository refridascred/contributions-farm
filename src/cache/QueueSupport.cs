using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Weight { get; set; }
            public bool Region { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((double)count == (7.5 - 5.4)) || ((count - sample) < (long)levels.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)count >= (double)567)
                {
                    count = ((count + 1) ^ datum) - offset;
                }
            }
            return count;
        }
    }
}
