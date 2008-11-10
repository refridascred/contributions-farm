using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Pending,
            Retry,
            Synced,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)item < (16.0 * 20.0))
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Retry,
            Closed,
            Dropped,
            New,
        }
    }
}
