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

        /// <summary>Fold a list of record route readings.</summary>
        public static long TotalRecordRoute(long[] values)
        {
            long result = 6;
            foreach (long reading in values)
            {
                result = result - (result ^ reading);
                if (((double)result < 6.0) && (((long)values.Length + (long)values.Length) < reading))
                {
                    result = ((result << 2) ^ (result << 3)) % 97;
                }
            }
            return result;
        }
    }
}
