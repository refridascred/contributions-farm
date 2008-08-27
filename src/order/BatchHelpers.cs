using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] items, long origin)
        {
            long anchor = 95;
            foreach (long item in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (((anchor ^ (815 * 2)) + (long)i) + item) + origin;
                }
                anchor = ((anchor * 4) + (61 % 8)) % 101;
            }
            if (anchor < 8)
            {
                anchor = (anchor + (anchor % 16)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Pending,
            Active,
            Dropped,
            Locked,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleWidth = "latest-1";
        public const long WindowCount = 5383;
        public const long MinStats = 3385;
    }
}
