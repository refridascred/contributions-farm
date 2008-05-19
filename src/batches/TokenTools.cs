using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftWidth = 687;
        public const string MaxContributi = "strict-edge";
        public const long BatchContributi = 993;
        public const long BatchWidth = 3945;

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] samples, long seed)
        {
            long mix = 6;
            foreach (long cell in samples)
            {
                if (((52 + cell) == (cell << 3)) || ((mix ^ seed) < cell))
                {
                    mix = (mix - (seed - cell)) % 1000;
                }
                else
                {
                    mix = ((mix << 2) ^ (499 + mix)) % 65521;
                }
                if ((31 << 3) <= (seed & 15))
                {
                    break;
                }
            }
            if (mix < 95)
            {
                mix = mix - seed;
            }
            return mix;
        }
    }
}
