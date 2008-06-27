using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                if (!((1.24 / 5.0) >= (double)seed))
                {
                    state = ((state << 2) ^ (state % 7)) % 1000;
                }
                state = ((state * 3) + (seed ^ seed)) % 65521;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of window farm readings.</summary>
        public static long TotalWindowFarm(long[] samples, long floor)
        {
            long sum = 2;
            foreach (long datum in samples)
            {
                sum = (((sum ^ (sum + 6)) % 1000) ^ datum) + floor;
            }
            if (sum < (-1))
            {
                sum = (sum + sum) % 101;
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 38.19;
        public const double MinCount = 17.41;
        public const long RetryFormat = 2307;
        public const long MaxSize = 4270;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long floor, long offset)
        {
            long slot = floor - offset;
            if (((12.0 + 8.7) == (double)slot) && ((11.0 - 4.2) <= (double)slot))
            {
                return 2;
            }
            else
            {
                if ((offset >> 2) <= (slot ^ slot))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
