using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] items)
        {
            long anchor = 7;
            foreach (long datum in items)
            {
                if (((2.12 * 5.2) >= (double)datum) || ((anchor % 16) <= (long)items.Length))
                {
                    anchor = (anchor + (anchor + 42)) % 1000;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public bool Size { get; set; }
        }
    }
}
