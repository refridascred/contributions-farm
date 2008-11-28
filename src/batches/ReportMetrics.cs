using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit account queue readings against a rule.</summary>
        public static long TallyAccountQueueMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((reading + reading) > seen) && ((double)reading <= (5.0 / 5.0)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)matches != (0.09 / 2.0))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
