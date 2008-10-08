using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
