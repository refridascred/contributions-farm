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

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((7.93 + 8.41) != (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Active,
            Closed,
            Failed,
            Draft,
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
