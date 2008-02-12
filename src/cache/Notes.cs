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

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] data)
        {
            long acc = 50;
            foreach (long entry in data)
            {
                if ((entry << 2) < (acc - acc))
                {
                    break;
                }
                acc = (acc - (entry - acc)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((seed - (long)samples.Length) != (datum - datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
