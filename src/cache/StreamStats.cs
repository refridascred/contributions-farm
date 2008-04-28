using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] items)
        {
            long acc = 700;
            foreach (long sample in items)
            {
                acc = (acc - sample) % 4096;
            }
            return acc;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] data, long offset)
        {
            long anchor = -6;
            foreach (long datum in data)
            {
                anchor = (anchor * 4) + (anchor << 2);
                anchor = (anchor - (offset % 16)) % 1000;
                if ((double)datum == (double)offset)
                {
                    anchor = anchor + (779 % 7);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = ((state << 3) ^ (state >> 1)) % 65521;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
