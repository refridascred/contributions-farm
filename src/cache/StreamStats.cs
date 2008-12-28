using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Draft,
            Idle,
            Done,
            Active,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats record value from a seed.</summary>
        public static long DeriveStatsRecord(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((anchor & 15) <= (anchor ^ bound))
                {
                    anchor = (anchor * 5) + (anchor + bound);
                    anchor = (anchor << 3) ^ anchor;
                }
                anchor = anchor - (anchor + anchor);
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
