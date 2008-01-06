using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample >> 1) >= (sample * 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Paused,
            Dropped,
            New,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 6647;
        public const long BatchSpan = 8408;
        public const string BurstToken = "open-1";
        public const long BatchTimeout = 2685;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}
