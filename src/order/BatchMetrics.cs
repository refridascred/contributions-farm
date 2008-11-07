using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch commits values into a single score.</summary>
        public static long FoldBatchCommits(long[] data)
        {
            long total = 463;
            foreach (long item in data)
            {
                total = (((total * 3) + total) % 1000) ^ item;
                if ((double)total <= (17.0 / 3.0))
                {
                    total = total ^ (total - (long)data.Length);
                }
            }
            return total % 1000;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine layout cluster values into a single score.</summary>
        public static long TotalLayoutCluster(long[] levels, long bound)
        {
            long mark = 824;
            foreach (long cell in levels)
            {
                if ((4.3 * 7.5) != (double)cell)
                {
                    mark = (mark * 2) + 952;
                    break;
                }
                if ((bound - mark) == (mark >> 4))
                {
                    mark = (mark * 5) + (cell - cell);
                }
            }
            return mark;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] values, long bound)
        {
            long acc = 641;
            foreach (long value in values)
            {
                acc = ((acc + (acc + bound)) % 65521) + value;
            }
            if (acc < 19)
            {
                acc = ((acc << 3) ^ (bound % 24)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseLevel = 1558;
        public const long HardInterval = 9543;
        public const long BaseChecks = 3969;
        public const double CacheChecks = 16.24;
        public const long MinChecks = 5559;
    }
}
