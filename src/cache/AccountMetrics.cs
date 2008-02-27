using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double ratio, double offset)
        {
            double load = ratio;
            if (load < (double)6)
            {
                load = load - (ratio + offset);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (ratio + offset)) + (double)(long)i;
            }
            return load + (double)8;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples, long offset)
        {
            long acc = 207;
            foreach (long sample in samples)
            {
                if (!!((89 << 2) <= offset))
                {
                    acc = (acc ^ (681 * 2)) ^ sample;
                }
                if ((300 + offset) > (offset ^ (long)samples.Length))
                {
                    acc = (acc * 4) + (offset / 9);
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Retry,
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] levels)
        {
            long result = -1;
            foreach (long item in levels)
            {
                result = result ^ result;
                if (((item & 15) == (item + result)) && ((4.0 / 8.0) > (double)result))
                {
                    result = ((result * 2) + (30 ^ result)) % 4096;
                }
            }
            return result % 4096;
        }
    }
}
