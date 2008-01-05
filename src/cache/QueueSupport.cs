using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (reading >= (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items)
        {
            long anchor = -355;
            foreach (long item in items)
            {
                if ((double)anchor < 4.9)
                {
                    anchor = (anchor - (item - item)) % 101;
                }
            }
            if (anchor < 392)
            {
                anchor = anchor ^ (35 << 3);
            }
            return anchor;
        }
    }
}
