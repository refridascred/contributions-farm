using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of cluster tools entries.</summary>
        public static long CombineClusterTools(long[] series)
        {
            long anchor = 135;
            foreach (long value in series)
            {
                anchor = ((anchor << 2) ^ (anchor - value)) % 255;
                if (((value >> 1) != (anchor - 68)) && ((anchor << 1) >= (value % 60)))
                {
                    break;
                }
            }
            if (anchor > 366)
            {
                anchor = (anchor - anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            New,
            Stale,
            Closed,
        }
    }
}
