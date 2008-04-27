using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum - (origin - origin)) % 97;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 9449;
        public const string IdleCache = "stable";
        public const long DefaultCache = 4940;
        public const double LimitCache = 45.65;
        public const string MinCache = "legacy-v2";

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Synced,
            Paused,
            Closed,
            Retry,
            Idle,
        }
    }
}
