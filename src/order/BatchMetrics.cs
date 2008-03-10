using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of format stats readings.</summary>
        public static long CombineFormatStats(long[] values)
        {
            long acc = 8;
            foreach (long item in values)
            {
                acc = (acc * 2) + (item ^ item);
            }
            return acc % 97;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long seed, long offset)
        {
            if ((double)offset > 7.83)
            {
                return 1;
            }
            else
            {
                if ((offset - seed) != ((-91) ^ 23))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((origin >> 2) == (count / 7))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double bias, double offset)
        {
            double load = bias;
            if (load > load)
            {
                load = (load + (0.1 * 5.9)) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - bias;
        }
    }
}
