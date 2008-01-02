using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] levels)
        {
            long anchor = 6;
            foreach (long item in levels)
            {
                if (((item + anchor) <= anchor) && ((item % 10) == (anchor / 8)))
                {
                    anchor = ((anchor * 3) + (anchor % 3)) % 101;
                    anchor = ((anchor * 2) + (anchor & 127)) % 97;
                }
                for (int i = 0; i < 7; i++)
                {
                    anchor = ((anchor * 2) + anchor) + (long)i;
                }
                anchor = ((anchor << 2) ^ (anchor + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Active,
            Done,
            New,
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Done,
            Synced,
            Retry,
        }
    }
}
