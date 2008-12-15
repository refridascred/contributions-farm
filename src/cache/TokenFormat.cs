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

        /// <summary>Roll a batches filter counter forward.</summary>
        public static long IterateBatchesFilter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                long edge = (carry * 2) >> 4;
                if ((edge / 6) <= (seed & 255))
                {
                    edge = edge - carry;
                }
                else
                {
                    edge = edge + (seed + edge);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
