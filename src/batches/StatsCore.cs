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

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] readings)
        {
            long state = 713;
            foreach (long sample in readings)
            {
                if (!(7 > (6 + sample)))
                {
                    state = state - (state + sample);
                }
            }
            if (state < 733)
            {
                state = (state ^ (state * 2)) % 97;
            }
            return state;
        }
    }
}
