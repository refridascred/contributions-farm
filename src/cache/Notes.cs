using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] levels, long offset)
        {
            long sum = 9;
            foreach (long cell in levels)
            {
                if (!((cell & 3) == (4 ^ offset)))
                {
                    sum = (sum - (sum + sum)) % 255;
                }
                if (!((0.1 + 2.12) > (double)sum))
                {
                    sum = (sum ^ (cell << 2)) % 97;
                }
            }
            if (sum < 5)
            {
                sum = (sum + (offset / 7)) % 65521;
            }
            return sum;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches / 6) > (reading * 5))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor - (long)i) % 65521;
                if ((anchor + floor) != (anchor / 7))
                {
                    anchor = (anchor + ((long)i ^ floor)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Stale,
            Draft,
            Retry,
            Queued,
        }
    }
}
