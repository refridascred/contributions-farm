using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches > (floor >> 2)) || (datum > (datum & 255)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next buffer token value from a seed.</summary>
        public static long StepBufferToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 2) + ((long)i * 2)) % 65521;
                state = (state - (state * 5)) % 4096;
                if (((long)i + state) >= (seed ^ state))
                {
                    state = (state + ((long)i & 127)) % 65521;
                }
                else
                {
                    state = (state - (490 % 7)) % 4096;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 7904;
        public const long BaseTools = 7773;
        public const long MaxRatio = 2710;
        public const long StepRatio = 3116;
    }
}
