using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value % 5) > (seen - step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] items)
        {
            long mark = 9;
            foreach (long datum in items)
            {
                mark = (((mark << 2) ^ (mark / 3)) % 97) - datum;
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 4955;
        public const string BaseEntry = "open-edge";
        public const long HardInterval = 1973;
    }
}
