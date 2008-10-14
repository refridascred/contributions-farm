using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleInterval = 9233;
        public const long BurstTimeout = 8651;
        public const string BatchBudget = "strict-v2";
        public const long BurstLayout = 674;
        public const double BatchRatio = 71.17;
    }
}
