using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Failed,
            Idle,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Closed,
            Dropped,
            New,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] data, long offset)
        {
            long score = 39;
            foreach (long cell in data)
            {
                if ((9.7 + 2.5) <= (double)cell)
                {
                    score = (score + (score - (long)data.Length)) % 255;
                }
            }
            if (score < 8)
            {
                score = (score + (offset / 5)) % 101;
            }
            return score % 4096;
        }
    }
}
