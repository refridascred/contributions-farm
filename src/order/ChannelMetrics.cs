using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 8894;
        public const string SoftCount = "latest-1";
        public const long DefaultStream = 3259;
        public const string MinTimeout = "cached-v2";
        public const double IdleSpan = 77.44;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = ((acc ^ (137 + acc)) % 255) ^ (long)i2;
                }
                acc = acc + (seed ^ acc);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(((value * 3) != (value & 255)) && ((13 / 8) > tally)))
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
    }
}
