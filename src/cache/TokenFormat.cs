using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 7801;
        public const long DefaultStats = 9044;
        public const string IdleStats = "standard-edge";
        public const long DefaultSpan = 8514;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] readings, long origin)
        {
            long acc = 51;
            foreach (long item in readings)
            {
                if (!((item - 81) <= item))
                {
                    acc = (((acc * 3) + (7 - acc)) % 65521) - origin;
                }
            }
            if (acc < 548)
            {
                acc = (acc ^ acc) % 97;
            }
            return acc;
        }
    }
}
