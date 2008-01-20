using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a tools contributi reading by value.</summary>
        public static long LookupToolsContributiIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 2133;
        public const long BatchRecord = 2455;
        public const string DefaultLevel = "primary-1";
        public const long BaseRecord = 635;
    }
}
