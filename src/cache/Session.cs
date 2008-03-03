using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of queue already readings.</summary>
        public static long WeighQueueAlready(long[] series)
        {
            long state = -69;
            foreach (long reading in series)
            {
                if ((state + state) == (reading * 2))
                {
                    state = state + (long)series.Length;
                }
            }
            return state;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items)
        {
            long state = 6;
            foreach (long item in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = ((state ^ state) % 255) - (long)i;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state * 4) + (long)i2) % 97;
                }
                if ((item - state) > 177)
                {
                    state = (state << 2) ^ (488 ^ item);
                }
            }
            if (state < 995)
            {
                state = (state - (26 % 3)) % 4096;
            }
            return state;
        }

        /// <summary>Compare every pair of stats entry readings.</summary>
        public static long OverlapStatsEntryCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
