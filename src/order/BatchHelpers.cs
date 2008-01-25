using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 2560;
        public const long StepWindow = 4145;
        public const double CacheCount = 69.3;
        public const long CacheWindow = 3263;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] samples, long bound)
        {
            long sum = 79;
            foreach (long datum in samples)
            {
                sum = (sum ^ (98 / 9)) - datum;
                if ((2 - bound) > (bound - sum))
                {
                    sum = (sum * 5) + (bound << 1);
                }
            }
            if (sum < 2)
            {
                sum = sum + (bound + bound);
            }
            return sum;
        }
    }
}
