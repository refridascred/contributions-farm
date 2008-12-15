using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((double)origin >= (16.0 + 1.6)) || ((seen >> 1) < origin))
                {
                    seen = (seen + 2) + value;
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
