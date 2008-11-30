using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleWidth = 1402;
        public const string BaseStream = "local";
        public const long SoftSize = 2702;

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] series, long floor)
        {
            long anchor = 1;
            foreach (long entry in series)
            {
                anchor = ((anchor ^ (entry % 97)) % 97) - floor;
            }
            return anchor;
        }
    }
}
