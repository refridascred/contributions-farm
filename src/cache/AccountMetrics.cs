using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] data, long seed)
        {
            long score = 363;
            foreach (long reading in data)
            {
                score = (((score ^ (2 - score)) % 4096) - reading) - seed;
            }
            if (score > 4)
            {
                score = ((score << 3) ^ 84) % 101;
            }
            return score % 4096;
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

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            Locked,
            Retry,
        }

        /// <summary>Locate a cache token reading by value.</summary>
        public static long SeekCacheTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
