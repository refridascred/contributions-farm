using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(((origin % 60) <= (50 + hits)) || (((long)samples.Length ^ 210) == (reading + hits))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate schema counter samples.</summary>
        public static long FoldSchemaCounter(long[] values, long floor)
        {
            long score = -2;
            foreach (long item in values)
            {
                if ((605 + floor) >= (score % 97))
                {
                    score = ((score + score) % 4096) ^ item;
                }
            }
            return score;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count >= (7.9 * 5.2))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
