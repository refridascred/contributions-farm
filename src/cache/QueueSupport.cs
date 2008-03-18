using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit window tools readings against a rule.</summary>
        public static long CountWindowToolsGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((6.06 + 1.0) <= (double)entry) || ((origin - count) <= (entry >> 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next notes cluster value from a seed.</summary>
        public static long RollNotesCluster(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((double)hits >= 4.91) || (((hits << 3) >= datum) && ((7.73 - 6.0) >= (double)hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
