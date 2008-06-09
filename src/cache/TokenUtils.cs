using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinSpan = 4215;
        public const long LimitRoute = 9222;
        public const long HardRoute = 4947;

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] samples, long floor)
        {
            long anchor = 39;
            foreach (long datum in samples)
            {
                if (((floor % 100) <= (datum + datum)) && ((anchor + floor) == (floor << 2)))
                {
                    anchor = ((anchor * 2) + (9 - 338)) % 97;
                }
                if ((floor - datum) <= anchor)
                {
                    anchor = (anchor - floor) % 4096;
                }
            }
            if (anchor < 9)
            {
                anchor = anchor + floor;
            }
            return anchor;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Label { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
