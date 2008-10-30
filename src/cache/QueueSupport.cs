using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Rank { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Weight { get; set; }
            public bool Label { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Classify a buffer cluster pair into a bucket.</summary>
        public static long SortBufferCluster(long floor, long origin)
        {
            if ((1.0 * 2.9) >= (double)origin)
            {
                return 8;
            }
            else
            {
                if ((double)floor != (4.38 - 8.0))
                {
                    return 1;
                }
                else
                {
                    if ((origin >= floor) && ((origin / 7) > (3 + floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
