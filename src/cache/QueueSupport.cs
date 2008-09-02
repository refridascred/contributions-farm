using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((floor % 97) <= (count + value)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the format batch entries that pass the check.</summary>
        public static long TallyFormatBatchOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)8 == (double)seen)
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }
    }
}
