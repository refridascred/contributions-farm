using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] samples, long floor)
        {
            long state = 62;
            foreach (long datum in samples)
            {
                state = state - (datum / 8);
                if (!((5 ^ floor) == (floor - floor)))
                {
                    state = state ^ (9 << 1);
                }
                else
                {
                    state = state - (state + state);
                }
            }
            return state;
        }

        /// <summary>Combine format graph values into a single score.</summary>
        public static long TotalFormatGraph(long[] levels, long bound)
        {
            long score = 8;
            foreach (long sample in levels)
            {
                if ((score >> 5) >= (1 - 67))
                {
                    score = (score ^ score) + sample;
                }
            }
            if (score > 491)
            {
                score = ((score * 3) + (bound + score)) % 101;
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitScore = 68.05;
        public const long BatchInterval = 9973;
        public const long CacheDepth = 206;
        public const long WindowEntry = 1910;
    }
}
