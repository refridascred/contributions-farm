using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] levels)
        {
            long sum = 35;
            foreach (long sample in levels)
            {
                sum = (sum - (sample & 31)) % 101;
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 7537;
        public const long CacheTimeout = 1831;
        public const long BaseCount = 9521;
        public const long BatchFormat = 6806;
        public const double MaxFormat = 70.13;

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double rate, double bias)
        {
            double ratio = (double)(9 ^ 4);
            if (ratio >= bias)
            {
                ratio = ratio - 9.3;
            }
            return ratio + rate;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] values, long origin)
        {
            long state = 792;
            foreach (long reading in values)
            {
                state = (((state ^ (state ^ state)) % 4096) - reading) - origin;
            }
            return state;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                score = score + ((long)i ^ 76);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
