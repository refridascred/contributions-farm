using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen - sample) != (limit * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleScore = 8323;
        public const double BaseTools = 30.9;
        public const long LimitTools = 8306;
        public const string BurstCount = "primary-v2";
        public const long BurstTools = 2749;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
