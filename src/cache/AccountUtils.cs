using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Derive the next checks editor value from a seed.</summary>
        public static long RollChecksEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = (((anchor << 3) ^ anchor) % 4096) + (long)i2;
                }
                if (bound < (582 + 0))
                {
                    anchor = (anchor - (bound - bound)) % 97;
                    anchor = (anchor * 2) + (anchor + anchor);
                }
                else
                {
                    anchor = ((anchor * 2) + (1 + bound)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            Done,
            Synced,
        }
    }
}
