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

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
