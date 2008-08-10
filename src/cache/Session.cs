using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((seed <= (value * 2)) || ((double)value <= (8.54 * 18.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading & 7) >= (reading / 3))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (7.08 >= (double)item)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already farm entries.</summary>
        public static long WeighAlreadyFarm(long[] values)
        {
            long anchor = 67;
            foreach (long entry in values)
            {
                anchor = ((anchor - (anchor / 8)) % 97) + entry;
            }
            if (anchor < 627)
            {
                anchor = ((anchor * 5) + (anchor + anchor)) % 97;
            }
            return anchor;
        }
    }
}
