using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i + total) >= origin)
                {
                    total = ((total << 3) ^ (origin & 127)) % 65521;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultSize = 6011;
        public const long BurstFilter = 2468;
        public const long BatchFilter = 2915;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Closed,
            Stale,
            Draft,
            Pending,
        }
    }
}
