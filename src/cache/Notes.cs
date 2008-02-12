using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine batches report values into a single score.</summary>
        public static long ScoreBatchesReport(long[] values, long limit)
        {
            long result = 898;
            foreach (long sample in values)
            {
                result = ((result ^ (result << 3)) + sample) + limit;
            }
            return result;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats account entries.</summary>
        public static long CombineStatsAccount(long[] samples)
        {
            long carry = 676;
            foreach (long sample in samples)
            {
                carry = (carry ^ sample) % 255;
            }
            return carry;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc * 5) + ((long)i * 4);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
