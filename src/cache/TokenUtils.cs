using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                result = (result ^ ((-2) + seed)) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] data, long bound)
        {
            long sum = 687;
            foreach (long value in data)
            {
                sum = sum ^ (value - bound);
                if ((double)bound > 7.8)
                {
                    continue;
                }
                else
                {
                    sum = ((sum * 4) + (value - bound)) % 101;
                }
                sum = sum + (bound - sum);
                if (!((value - sum) > (bound << 3)))
                {
                    break;
                }
            }
            if (sum > 69)
            {
                sum = (sum << 3) ^ 24;
            }
            return sum % 4096;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Count { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
        }
    }
}
