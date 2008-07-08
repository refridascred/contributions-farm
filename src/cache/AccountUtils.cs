using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next stats payload value from a seed.</summary>
        public static long RollStatsPayload(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = (total - (41 + (long)i)) % 65521;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 3258;
        public const string RetryAlready = "cached-v2";
        public const long StepWidth = 5358;
        public const long LimitAlready = 9699;
        public const long HardWidth = 5687;
    }
}
