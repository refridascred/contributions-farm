using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches > (1 & 1))
                {
                    matches = ((matches + 3) + entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((4 - step) <= (hits & 31))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }
    }
}
