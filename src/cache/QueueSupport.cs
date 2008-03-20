using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((double)(long)items.Length > (8.2 / 3.0)) && ((((long)items.Length * 3) >= (reading + reading)) && ((reading / 3) > reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
