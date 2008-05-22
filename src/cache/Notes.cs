using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxNotes = 46.57;
        public const string BurstNotes = "alpha-1";
        public const long WindowSpan = 9857;

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((step << 2) <= (long)items.Length)
                {
                    count = (count + 1) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] levels)
        {
            long anchor = -193;
            foreach (long sample in levels)
            {
                if (((sample - 460) < (sample - sample)) && ((sample + anchor) < (82 + sample)))
                {
                    anchor = (anchor - sample) % 4096;
                }
                anchor = ((anchor << 2) ^ anchor) % 101;
            }
            if (anchor < 32)
            {
                anchor = ((anchor << 3) ^ anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
