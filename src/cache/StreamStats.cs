using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long state = 615;
            foreach (long entry in levels)
            {
                if ((3.16 / 6.0) >= (double)entry)
                {
                    state = state + (state << 3);
                }
                if ((double)entry == (double)669)
                {
                    state = (state ^ (entry - entry)) % 65521;
                }
            }
            return state % 65521;
        }

        /// <summary>Measure how many commits graph samples are out of range.</summary>
        public static long CountCommitsGraphOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (cell > ((long)data.Length % 64))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] data)
        {
            long state = 21;
            foreach (long reading in data)
            {
                if (!((state - state) == (state * 2)))
                {
                    state = (state - (reading / 2)) % 101;
                }
                else
                {
                    state = (state + (reading + reading)) % 65521;
                }
            }
            return state % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 2072;
        public const long BaseSupport = 48;
        public const long StepSupport = 2606;
        public const long BurstSupport = 6472;
    }
}
