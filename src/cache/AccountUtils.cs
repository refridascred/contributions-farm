using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Iterate the layout support series from a seed.</summary>
        public static long IterateLayoutSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = anchor ^ origin;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] data, long target)
        {
            long anchor = 793;
            foreach (long value in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((anchor ^ (anchor + anchor)) % 1000) ^ (long)i;
                }
                if ((value >> 2) < target)
                {
                    anchor = ((anchor * 5) + (anchor >> 1)) % 4096;
                }
            }
            return anchor;
        }
    }
}
