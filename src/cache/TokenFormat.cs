using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next stats stream value from a seed.</summary>
        public static long IterateStatsStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = (result - ((-410) * 3)) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultEditor = 74.35;
        public const long MinInterval = 2443;
        public const string MinWidth = "local-edge";

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
