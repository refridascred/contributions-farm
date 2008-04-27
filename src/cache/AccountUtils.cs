using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] series, long bound)
        {
            long acc = -938;
            foreach (long value in series)
            {
                acc = ((acc + (76 % 64)) ^ value) - bound;
            }
            return acc;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((-4) - tally) > (tally / 8))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long origin2)
        {
            long next = origin + origin2;
            if (origin < (origin2 - origin2))
            {
                return 6;
            }
            else
            {
                if ((next << 1) == (origin - origin))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
