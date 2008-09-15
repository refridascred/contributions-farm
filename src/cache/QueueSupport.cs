using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value + hits) > value)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine report stream values into a single score.</summary>
        public static long TotalReportStream(long[] data)
        {
            long total = 2;
            foreach (long item in data)
            {
                total = ((total + total) % 255) ^ item;
            }
            if (total > 5)
            {
                total = (total + (total << 2)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Locked,
            Synced,
            Failed,
        }
    }
}
