using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseLevel = 7900;
        public const long BurstTools = 1358;
        public const long IdleTools = 1004;
        public const long BurstTimeout = 8425;
        public const long WindowWidth = 2904;

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter record value against two limits.</summary>
        public static long RankCounterRecord(long floor, long seed)
        {
            long slot = floor - seed;
            if ((slot - slot) < (floor ^ seed))
            {
                return 7;
            }
            else
            {
                if ((5 >> 5) < (slot << 1))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
