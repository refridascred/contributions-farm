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

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 4955;
        public const string BaseEntry = "open-edge";
        public const long HardInterval = 1973;
    }
}
