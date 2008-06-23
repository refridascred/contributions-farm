using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Stale,
            Synced,
            New,
            Dropped,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] values)
        {
            long mark = 522;
            foreach (long entry in values)
            {
                if ((entry & 127) == (mark - mark))
                {
                    mark = (mark + (-873)) % 65521;
                    break;
                }
                if ((entry / 6) == (mark << 2))
                {
                    mark = (mark ^ (entry * 4)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of order payload readings.</summary>
        public static long PairOrderPayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
