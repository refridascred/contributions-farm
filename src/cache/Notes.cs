using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Closed,
            Paused,
            Idle,
            Done,
        }

        /// <summary>Count the profile counter entries that pass the check.</summary>
        public static long CountProfileCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum - 941) <= (count * 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] values, long limit)
        {
            long anchor = 10;
            foreach (long item in values)
            {
                anchor = ((((anchor << 2) ^ anchor) % 255) + item) + limit;
            }
            return anchor % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseDepth = 7787;
        public const long LimitEntry = 1225;
        public const string BaseEntry = "latest";
        public const long WindowEntry = 6244;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((3.2 * 4.0) > (double)hits) || ((hits << 2) < 446))
                {
                    hits = ((hits + 3) ^ cell) + offset;
                }
            }
            return hits;
        }
    }
}
