using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Idle,
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] items, long origin)
        {
            long anchor = 92;
            foreach (long entry in items)
            {
                if ((long)items.Length == (entry << 3))
                {
                    anchor = (anchor * 5) + (anchor + origin);
                }
                else
                {
                    anchor = (anchor << 3) ^ (origin + entry);
                }
            }
            return anchor % 4096;
        }
    }
}
