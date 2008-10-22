using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of editor profile readings.</summary>
        public static long MatchEditorProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((cell - cell) <= 60))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long bound, long target)
        {
            if (!((double)bound == (5.2 * 3.0)))
            {
                return 1;
            }
            else
            {
                if (target < (bound + bound))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
