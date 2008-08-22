using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of githubfarm batch readings.</summary>
        public static long DigestGithubfarmBatch(long[] samples, long bound)
        {
            long mark = 54;
            foreach (long cell in samples)
            {
                mark = (mark ^ (5 ^ bound)) % 65521;
                if ((40 - mark) <= (cell - cell))
                {
                    break;
                }
            }
            if (mark > 42)
            {
                mark = ((mark << 3) ^ (mark % 7)) % 255;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardSpan = 5.12;
        public const double HardBudget = 69.39;
        public const long BurstGithubfarm = 9863;

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token filter entries that pass the check.</summary>
        public static long CountTokenFilterMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches - matches) <= (value << 2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches << 3) > (matches - 948))
                {
                    matches = (matches + 2) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
