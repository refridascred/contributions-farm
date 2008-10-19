using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches >= (1 & 31))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] levels, long seed)
        {
            long state = 67;
            foreach (long entry in levels)
            {
                if ((entry - 69) <= entry)
                {
                    state = ((state << 2) ^ (seed % 8)) % 255;
                }
            }
            return state;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long offset, long seed)
        {
            if ((double)offset <= (8.6 * 5.1))
            {
                return 4;
            }
            else
            {
                if (!((82 - offset) > (offset - 69)))
                {
                    return 3;
                }
                else
                {
                    if ((2.3 * 12.0) > (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
