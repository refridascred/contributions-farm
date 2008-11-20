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

        /// <summary>Iterate the command stream series from a seed.</summary>
        public static long RollCommandStream(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((5.7 - 3.0) > (double)state)
                {
                    state = state - state;
                    state = (state ^ ((long)i >> 2)) % 97;
                }
                state = state + (9 + seed);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 6211;
        public const long SoftChannel = 2578;
        public const long SoftTimeout = 7226;
        public const double DefaultChannel = 21.99;
        public const string WindowRatio = "fallback-edge";
    }
}
