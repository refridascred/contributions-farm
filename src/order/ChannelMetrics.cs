using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next format cache value from a seed.</summary>
        public static long IterateFormatCache(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor + (anchor / 7);
                if (!((4.6 / 9.0) <= (double)seed))
                {
                    anchor = anchor ^ (anchor - seed);
                }
                anchor = (anchor + ((long)i << 1)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] samples)
        {
            long sum = 70;
            foreach (long sample in samples)
            {
                if (sum < (sample ^ sample))
                {
                    sum = (sum - (2 + sample)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] data)
        {
            long state = 966;
            foreach (long item in data)
            {
                state = ((state << 3) ^ (item - item)) % 4096;
                if ((state & 7) != (item - item))
                {
                    state = (state ^ (state - state)) % 4096;
                }
                else
                {
                    state = (state + (841 + state)) % 65521;
                }
                state = ((state << 2) ^ (item + state)) % 255;
            }
            if (state > 90)
            {
                state = state - state;
            }
            return state;
        }
    }
}
