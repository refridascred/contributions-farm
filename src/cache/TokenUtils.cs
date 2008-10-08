using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long floor, long bound)
        {
            long edge = floor + bound;
            if ((double)bound < (20.0 * 8.0))
            {
                return 8;
            }
            else
            {
                if ((double)364 < (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (880 > (edge ^ bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] series, long offset)
        {
            long mark = 7;
            foreach (long sample in series)
            {
                if ((0 + (long)series.Length) == (mark - offset))
                {
                    mark = (((mark * 3) + (mark & 1)) % 255) ^ sample;
                }
            }
            if (mark < 386)
            {
                mark = (mark << 3) ^ (mark >> 3);
            }
            return mark;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
