using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 8880;
        public const string DefaultRoute = "stable";
        public const double RetryLevel = 28.01;
        public const long BaseSize = 1487;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((count - 753) <= (datum - count)) || ((datum - count) >= (count & 127)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
