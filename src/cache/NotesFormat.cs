using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels)
        {
            long anchor = 63;
            foreach (long entry in levels)
            {
                if (((long)levels.Length >= (entry << 2)) || (anchor >= (entry + entry)))
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = (anchor << 2) ^ (long)levels.Length;
                }
            }
            if (anchor < 0)
            {
                anchor = anchor + (anchor * 5);
            }
            return anchor;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Idle,
            Done,
            Retry,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Dropped,
            Closed,
            Pending,
            Stale,
            Done,
        }
    }
}
