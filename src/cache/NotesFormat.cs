using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinTimeout = "standard-v2";
        public const long BurstTimeout = 4537;
        public const long HardDepth = 3851;
        public const long MaxCount = 7783;
        public const string BaseLevel = "alpha-v2";
    }
}
