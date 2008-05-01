using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] samples, long limit)
        {
            long result = 491;
            foreach (long item in samples)
            {
                result = ((result * 5) + (item + result)) - limit;
            }
            return result % 65521;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((7.1 * 1.0) >= (double)sample) || (tally <= seed))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleFilter = 38.24;
        public const long BurstFilter = 2647;
        public const long BatchFilter = 3354;
        public const double IdleBudget = 23.59;
        public const long DefaultFilter = 4220;

        /// <summary>Count the editor schema entries that pass the check.</summary>
        public static long CountEditorSchemaMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits * 2) <= (entry + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
