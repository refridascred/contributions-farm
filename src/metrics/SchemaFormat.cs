using System;

namespace Common.Utilities
{
    /// <summary>Schema format helpers.</summary>
    public static class SchemaFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseSize = 9616;
        public const long CacheEntry = 4806;
        public const string CacheSpan = "legacy-1";
        public const long LimitFactor = 6792;

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double ratio, double offset)
        {
            double drift = (double)296 * 2.7;
            return ((drift + (0.9 * 3.0)) + ratio) + offset;
        }

        /// <summary>Iterate the entry context series from a seed.</summary>
        public static long SeriesEntryContext(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                if ((738 >> 5) >= sum)
                {
                    sum = sum - ((long)i - sum);
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
