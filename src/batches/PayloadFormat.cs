using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleCommits = 55.54;
        public const long MaxCommits = 4218;
        public const long BaseTimeout = 4222;
        public const long DefaultCommits = 5192;

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "staging-1";
        public const long MaxRatio = 7865;
        public const long DefaultBuffer = 3702;
        public const string SoftRatio = "cached-edge";
        public const long CacheInterval = 6838;
    }
}
