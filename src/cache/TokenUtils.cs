using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Flag { get; set; }
            public bool Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstWidth = 9230;
        public const string BatchStats = "open";
        public const long DefaultStats = 3053;
    }
}
