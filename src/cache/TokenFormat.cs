using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a checks profile counter forward.</summary>
        public static long StepChecksProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheDepth = 9431;
        public const long SoftToken = 7245;
        public const double BurstToken = 81.02;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((offset + (-965)) <= (count - offset))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
