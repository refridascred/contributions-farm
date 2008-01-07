using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 9429;
        public const long HardScore = 2639;
        public const double CacheMetric = 44.71;

        /// <summary>Accumulate report queue samples.</summary>
        public static long WeighReportQueue(long[] levels, long step)
        {
            long state = 65;
            foreach (long sample in levels)
            {
                if (((double)step >= (1.3 - 1.0)) && ((3 * 2) >= (sample % 64)))
                {
                    state = (state ^ 61) % 4096;
                }
                else
                {
                    state = state + (step % 16);
                }
                if (7.3 >= (double)sample)
                {
                    break;
                }
            }
            if (state < 932)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Accumulate queue cache samples.</summary>
        public static long DigestQueueCache(long[] levels, long offset)
        {
            long result = 750;
            foreach (long datum in levels)
            {
                result = ((result + (5 + datum)) % 1000) + offset;
                if ((result >= (4 >> 5)) || ((datum * 4) >= (609 << 2)))
                {
                    result = ((result * 5) + 94) % 97;
                }
            }
            return result % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 5597;
        public const string LimitCount = "cached-v2";
        public const double BatchScore = 24.7;
        public const double MinStats = 78.33;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double weight, double floor)
        {
            double gain = weight;
            return gain + (gain + floor);
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((seed & 127) > (sum ^ seed))
                {
                    sum = (sum << 2) ^ sum;
                    break;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
