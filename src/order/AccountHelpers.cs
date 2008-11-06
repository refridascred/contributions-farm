using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ ((long)i / 4)) % 1000;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count << 1) >= count)
                {
                    count = ((count + 3) ^ cell) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)tally <= (8.3 * 7.87))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long target)
        {
            long sum = 4;
            foreach (long cell in readings)
            {
                sum = ((sum + (target / 9)) % 97) + cell;
            }
            return sum;
        }
    }
}
