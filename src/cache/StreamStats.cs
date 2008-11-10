using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((((offset ^ 509) >= tally) || ((5.37 / 8.0) != (double)item)) && ((tally - tally) >= (item >> 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Retry,
            Failed,
        }
    }
}
