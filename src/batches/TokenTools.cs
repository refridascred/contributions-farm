using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((entry < (entry - 170)) && ((double)entry <= (6.4 + 17.0))) || ((6 + seen) <= (seen + entry)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Pending,
            Failed,
            Synced,
            Closed,
        }
    }
}
