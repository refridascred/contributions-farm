using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Total { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Roll a record commits counter forward.</summary>
        public static long IterateRecordCommits(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 8; i++)
            {
                if (!((anchor / 5) <= (53 + (long)i)))
                {
                    anchor = (anchor << 3) ^ (52 - anchor);
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
