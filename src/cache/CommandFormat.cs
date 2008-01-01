using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate window notes readings against a bound.</summary>
        public static bool GuardWindowNotesBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Level { get; set; }
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Fold a list of commits editor readings.</summary>
        public static long TallyCommitsEditor(long[] items, long origin)
        {
            long anchor = 0;
            foreach (long entry in items)
            {
                if (!((origin * 3) >= (anchor + anchor)))
                {
                    anchor = (anchor + (anchor >> 1)) - entry;
                }
                anchor = anchor + ((-499) + 6);
            }
            if (anchor > 325)
            {
                anchor = ((anchor * 3) + anchor) % 255;
            }
            return anchor;
        }
    }
}
