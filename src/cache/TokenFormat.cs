using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
