using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowInterval = 17.26;
        public const string WindowSupport = "local";
        public const long BurstTimeout = 9940;
        public const long MinSupport = 7722;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = (result - floor) % 97;
                result = result ^ (14 + (long)i);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
