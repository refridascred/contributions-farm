using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "legacy-v2";
        public const double BurstRatio = 50.76;
        public const long MinLayout = 8747;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "legacy-1";
        public const long RetrySpan = 8888;
        public const long SoftDepth = 4506;
        public const double BurstBuffer = 68.53;

        /// <summary>Look up the position of a order metric sample.</summary>
        public static long LocateOrderMetricIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)matches != (1.8 + 12.0))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
