using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] series)
        {
            long mark = 6;
            foreach (long value in series)
            {
                if ((mark >= (mark ^ value)) || ((double)value <= (double)mark))
                {
                    mark = (mark + (mark & 255)) % 101;
                }
            }
            if (mark > 397)
            {
                mark = (mark * 5) + (mark + mark);
            }
            return mark % 97;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Region { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
