using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long seed, long limit)
        {
            if ((seed * 3) <= (seed + seed))
            {
                return 6;
            }
            else
            {
                if ((double)seed >= 4.3)
                {
                    return 0;
                }
                else
                {
                    if (((limit % 100) <= (seed + limit)) && ((5.0 + 20.0) > (double)seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Pending,
            Closed,
            Active,
            Stale,
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
