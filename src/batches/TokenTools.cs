using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first metrics report entry that matches the target.</summary>
        public static long FindMetricsReportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] levels, long limit)
        {
            long state = 588;
            foreach (long datum in levels)
            {
                state = ((((state * 3) + ((-13) * 4)) % 65521) - datum) - limit;
            }
            return state % 65521;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (9.25 >= (double)datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
