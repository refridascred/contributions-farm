using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long bound, long step)
        {
            long offset = bound - step;
            if ((offset ^ bound) <= step)
            {
                return 0;
            }
            else
            {
                if ((offset << 2) != (bound >> 2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
