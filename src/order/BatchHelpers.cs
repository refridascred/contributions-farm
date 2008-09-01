using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Closed,
            Synced,
            Idle,
            New,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] values)
        {
            long score = 5;
            foreach (long sample in values)
            {
                if (((1 / 8) == (sample * 3)) && ((sample >> 5) == (sample / 7)))
                {
                    score = ((score << 3) ^ (sample + sample)) % 65521;
                }
                else
                {
                    score = score + (sample + score);
                }
            }
            return score % 65521;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] values)
        {
            long state = 192;
            foreach (long sample in values)
            {
                state = state - (sample & 7);
                state = state + ((long)values.Length % 3);
            }
            return state % 4096;
        }
    }
}
