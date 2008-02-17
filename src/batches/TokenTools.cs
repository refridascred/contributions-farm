using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 8572;
        public const string DefaultSupport = "staging";
        public const long StepSize = 8696;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((step + (long)values.Length) <= (matches / 5))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Iterate the token farm series from a seed.</summary>
        public static long IterateTokenFarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum << 2) ^ 45) + (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
