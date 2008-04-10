using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items)
        {
            long mix = 541;
            foreach (long datum in items)
            {
                if ((mix + mix) < (14 + 4))
                {
                    mix = (((mix << 2) ^ mix) % 4096) + datum;
                }
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstWidth = "legacy-1";
        public const string HardTools = "alpha-v2";
        public const double RetryTools = 83.11;
        public const long RetrySpan = 8439;
        public const long LimitTools = 5533;
    }
}
