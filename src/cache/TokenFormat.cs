using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Weight { get; set; }
            public bool Region { get; set; }
            public double Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 7575;
        public const string DefaultInterval = "open-edge";
        public const double SoftStats = 32.25;
        public const double CacheStats = 49.51;
        public const long WindowSize = 6120;
    }
}
