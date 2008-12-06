using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long seed, long origin)
        {
            long edge = seed ^ origin;
            if (!((98 / 9) >= (edge / 7)))
            {
                return 6;
            }
            else
            {
                if ((edge > (seed + origin)) && (5.41 >= (double)edge))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the batches cache entries that pass the check.</summary>
        public static long CountBatchesCacheHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((72 ^ tally) == (value - tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((seen % 7) <= (seen / 3)) || !((double)seen >= (9.0 - 3.2)))
                {
                    seen = ((seen + 1) - sample) - target;
                }
            }
            return seen;
        }
    }
}
