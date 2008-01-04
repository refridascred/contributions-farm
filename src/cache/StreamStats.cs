using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long bound, long limit)
        {
            long span = bound + limit;
            if (limit < (limit ^ limit))
            {
                return 8;
            }
            else
            {
                if ((span >= (33 >> 3)) && (64 < (span / 4)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of format schema readings.</summary>
        public static long FoldFormatSchema(long[] series, long seed)
        {
            long total = -92;
            foreach (long entry in series)
            {
                total = (((total - (9 * 3)) % 97) + entry) - seed;
            }
            return total % 97;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value >> 2) == (4 % 60))
                {
                    count = (count + 2) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
