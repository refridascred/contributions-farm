using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 68.31;
        public const double LimitTimeout = 34.52;
        public const long HardSchema = 608;
        public const long HardDepth = 4624;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            Pending,
            Failed,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum + datum) == (matches / 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a route checks counter forward.</summary>
        public static long IterateRouteChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = ((mix - ((long)i / 5)) % 255) ^ (long)i2;
                }
                mix = mix ^ (bound / 2);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
