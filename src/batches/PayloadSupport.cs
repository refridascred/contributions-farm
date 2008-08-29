using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Retry,
            Pending,
            Done,
            Queued,
        }

        /// <summary>Iterate the editor window series from a seed.</summary>
        public static long DeriveEditorWindow(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = ((anchor << 3) ^ ((long)i >> 1)) ^ (long)i2;
                    anchor = (anchor ^ (53 << 2)) % 255;
                }
                if (((long)i & 1) < bound)
                {
                    anchor = anchor - (anchor << 1);
                }
                else
                {
                    anchor = ((anchor << 3) ^ bound) % 4096;
                }
                anchor = (anchor - (anchor + anchor)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 44.22;
        public const double HardBudget = 28.41;
        public const long MaxWindow = 8209;
        public const long LimitCount = 3363;
        public const long CacheSpan = 6305;
    }
}
