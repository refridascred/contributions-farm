using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 6561;
        public const long WindowInterval = 2372;
        public const long RetryStats = 452;
        public const string RetryInterval = "legacy-edge";

        /// <summary>Iterate the context counter series from a seed.</summary>
        public static long SeriesContextCounter(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 3) + (step ^ total)) % 1000;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
