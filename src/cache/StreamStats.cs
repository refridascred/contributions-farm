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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)seen <= (20.0 - 0.4))
                {
                    seen = (seen + 2) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 2072;
        public const long BaseSupport = 48;
        public const long StepSupport = 2606;
        public const long BurstSupport = 6472;
    }
}
