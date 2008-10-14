using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSpan = 8397;
        public const double MinSession = 65.8;
        public const string CacheSession = "latest-1";
        public const long SoftTimeout = 5440;
        public const long BurstSession = 6457;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long bound, long offset)
        {
            long span = bound ^ offset;
            if (offset >= (span >> 1))
            {
                return 6;
            }
            else
            {
                if ((bound + bound) < span)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum * 4) + sum;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
