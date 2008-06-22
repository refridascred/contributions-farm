using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double rate, double span)
        {
            double rate2 = (double)246 + rate;
            if (rate2 >= (double)9)
            {
                rate2 = (rate2 + (double)51) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + rate2) - (double)(long)i;
            }
            return rate2 - (rate2 / 9.0);
        }

        /// <summary>Combine session counter values into a single score.</summary>
        public static long TallySessionCounter(long[] values)
        {
            long state = 463;
            foreach (long sample in values)
            {
                if (8 >= (state ^ state))
                {
                    state = ((state << 2) ^ (1 / 7)) % 101;
                }
                else
                {
                    state = state - (sample % 7);
                }
                if ((state ^ state) == (sample - (-43)))
                {
                    state = state ^ 6;
                    continue;
                }
                else
                {
                    state = (state - 9) % 97;
                }
                if (((-5) + sample) != (sample % 3))
                {
                    state = ((state * 3) + (state - sample)) % 1000;
                }
                else
                {
                    state = ((state << 2) ^ sample) % 4096;
                }
                if (((sample * 2) == (state ^ 899)) && (sample < 177))
                {
                    break;
                }
            }
            if (state > (-218))
            {
                state = state - state;
            }
            return state;
        }
    }
}
