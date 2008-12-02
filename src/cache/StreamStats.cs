using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items)
        {
            long anchor = 907;
            foreach (long item in items)
            {
                if (((double)item >= (double)9) || ((anchor + item) != (60 / 5)))
                {
                    anchor = (anchor ^ item) % 65521;
                }
                anchor = (anchor + (anchor % 97)) % 4096;
                anchor = (anchor * 5) + (anchor - anchor);
            }
            if (anchor < 16)
            {
                anchor = anchor - (29 + (long)items.Length);
            }
            return anchor % 97;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Failed,
            Draft,
            Stale,
            Active,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Locked,
            Active,
            Dropped,
            Paused,
        }
    }
}
