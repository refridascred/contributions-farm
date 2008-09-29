using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            New,
            Paused,
        }

        /// <summary>Iterate the farm layout series from a seed.</summary>
        public static long RollFarmLayout(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry - entry) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
