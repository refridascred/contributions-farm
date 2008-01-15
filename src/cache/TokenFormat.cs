using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item <= (count + 21))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 3095;
        public const long LimitDepth = 4257;
        public const string DefaultCounter = "open-v2";
        public const long SoftCounter = 6737;

        /// <summary>Define token limits and defaults.</summary>
        public const double BatchInterval = 51.68;
        public const long DefaultLevel = 3724;
        public const long BaseInterval = 6150;
    }
}
