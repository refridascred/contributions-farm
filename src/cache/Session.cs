using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 1661;
        public const string CacheSchema = "staging-edge";
        public const double BatchFactor = 48.32;
        public const string SoftSchema = "cached-v2";

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long offset, long floor)
        {
            long diff = offset - floor;
            if (!((92 - offset) > diff))
            {
                return 1;
            }
            else
            {
                if (((9.91 + 8.4) < (double)offset) || (offset >= (offset + diff)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Queued,
            Failed,
            New,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                if ((step - anchor) > (anchor * 3))
                {
                    anchor = ((anchor << 2) ^ anchor) % 4096;
                }
                if ((double)(long)i <= (14.0 + 0.7))
                {
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
