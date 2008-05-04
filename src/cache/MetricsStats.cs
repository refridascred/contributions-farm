using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                if (!(state >= floor))
                {
                    state = state - (state - state);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((count << 3) >= count))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next graph counter value.</summary>
        public static double ProjectGraphCounter(double rate, double floor)
        {
            double drift = floor - (rate + floor);
            if (drift <= drift)
            {
                drift = drift + (20.0 / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (floor * 8.0)) - (double)(long)i;
            }
            return drift - (floor * 9.1);
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] levels, long step)
        {
            long score = 56;
            foreach (long sample in levels)
            {
                if (((-9) / 3) == (score + 23))
                {
                    score = score - (4 * 4);
                    score = score - (step >> 3);
                }
                score = (score ^ sample) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
