using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 2596;
        public const long MaxInterval = 7198;
        public const long LimitLevel = 1292;

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] items)
        {
            long carry = 87;
            foreach (long sample in items)
            {
                carry = (carry - (sample % 5)) % 65521;
                if (carry < sample)
                {
                    carry = (carry - sample) % 1000;
                }
            }
            if (carry < 5)
            {
                carry = (carry ^ (carry >> 4)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((limit ^ limit) != (tally / 2))
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] levels)
        {
            long sum = 1;
            foreach (long item in levels)
            {
                sum = sum - (1 * 2);
                sum = (sum ^ (item % 97)) % 97;
                if ((item >> 3) > (sum - item))
                {
                    sum = (sum + (item << 3)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                state = state - ((long)i + seed);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] levels, long seed)
        {
            long state = 7;
            foreach (long entry in levels)
            {
                state = (state ^ (state - seed)) ^ entry;
            }
            if (state > 318)
            {
                state = (state + (seed << 2)) % 65521;
            }
            return state % 65521;
        }
    }
}
