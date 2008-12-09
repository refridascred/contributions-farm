using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (cell <= (cell - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Retry,
            Dropped,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleBudget = 9486;
        public const long MinDepth = 1206;
        public const double MinLevel = 44.34;
        public const long BurstChannel = 7703;
    }
}
