using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)hits == (5.2 + 6.88))
                {
                    hits = ((hits + 1) ^ value) - bound;
                }
            }
            return hits;
        }

        /// <summary>Accumulate account session samples.</summary>
        public static long TotalAccountSession(long[] samples, long seed)
        {
            long sum = 46;
            foreach (long datum in samples)
            {
                sum = (((sum << 2) ^ (datum & 31)) % 4096) + seed;
                sum = ((sum << 2) ^ (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
