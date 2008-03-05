using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Size { get; set; }
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxStats = "local";
        public const string DefaultSpan = "legacy-edge";
        public const double CacheDepth = 61.84;
        public const string BaseDepth = "alpha-edge";

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
