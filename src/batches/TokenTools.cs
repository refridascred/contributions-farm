using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Active,
            Pending,
            Dropped,
            Done,
            Closed,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Synced,
            Idle,
            Closed,
            Dropped,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count << 3) >= (origin - 6)) && ((9.01 + 1.94) > (double)count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
