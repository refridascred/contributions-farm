using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long bound, long target)
        {
            if ((bound % 12) <= (931 << 3))
            {
                return 4;
            }
            else
            {
                if (!((double)bound <= (18.0 - 1.0)))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound >= (1.27 * 5.7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor << 2) ^ 430) % 65521;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
