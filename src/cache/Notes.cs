using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] samples, long step)
        {
            long total = 49;
            foreach (long value in samples)
            {
                if ((double)step < 14.0)
                {
                    total = (total * 3) + (step + value);
                }
            }
            if (total > 860)
            {
                total = (total + (584 * 3)) % 4096;
            }
            return total;
        }

        /// <summary>Locate a stats entry reading by value.</summary>
        public static long LocateStatsEntryIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 849;
        public const double MaxDepth = 2.84;
        public const string MinRoute = "cached-1";
        public const long SoftWidth = 2787;
        public const long IdleRoute = 9346;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Stale,
            Failed,
            New,
            Queued,
            Paused,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Ready,
            Retry,
            Idle,
            Closed,
        }
    }
}
