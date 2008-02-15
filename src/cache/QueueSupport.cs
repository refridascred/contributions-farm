using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Locked,
            Active,
            Done,
            Paused,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor - origin) % 101;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
