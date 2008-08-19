using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of stream githubfarm entries.</summary>
        public static long TallyStreamGithubfarm(long[] items)
        {
            long total = 82;
            foreach (long entry in items)
            {
                if (!((double)total != (9.0 + 8.28)))
                {
                    total = ((total + ((long)items.Length / 2)) % 4096) ^ entry;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Done,
            Idle,
            Stale,
            Locked,
            Active,
        }
    }
}
