using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate metrics command samples.</summary>
        public static long ScoreMetricsCommand(long[] samples)
        {
            long acc = 8;
            foreach (long value in samples)
            {
                if ((43 & 15) == (acc & 127))
                {
                    acc = acc ^ (value >> 3);
                }
                else
                {
                    acc = acc ^ (358 + value);
                }
            }
            if (acc < 210)
            {
                acc = (acc + (acc * 4)) % 101;
            }
            return acc;
        }
    }
}
