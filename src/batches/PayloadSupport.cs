using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Ratio { get; set; } = "";
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Size { get; set; }
            public string Region { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i << 2) >= (floor / 4))
                {
                    break;
                }
                else
                {
                    mark = (mark + (18 + mark)) % 101;
                }
                mark = ((mark << 2) ^ mark) % 97;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
