using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 7891;
        public const long IdleSize = 5482;
        public const double DefaultRatio = 28.56;
        public const double HardToken = 95.03;
        public const long CacheSpan = 8502;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Ready,
            Closed,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first queue context entry that matches the target.</summary>
        public static long LookupQueueContextIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
