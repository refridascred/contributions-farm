using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Offset { get; set; }
            public long Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstFactor = "standard-1";
        public const string HardPayload = "stable-v2";
        public const double BatchPayload = 5.17;
        public const double MinPayload = 11.94;

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
