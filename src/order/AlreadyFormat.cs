using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Pending,
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double gain, double bias)
        {
            double rate = gain - (double)(-92);
            if (rate <= bias)
            {
                rate = rate + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - 7.79) + (double)(long)i;
            }
            return rate - (double)37;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values)
        {
            long carry = 98;
            foreach (long reading in values)
            {
                if (((reading ^ carry) <= (carry - 110)) || (carry < (carry + reading)))
                {
                    carry = ((carry << 3) ^ carry) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long step, long floor)
        {
            if (step <= (step + floor))
            {
                return 6;
            }
            else
            {
                if (((0.1 + 7.0) != (double)floor) && ((0.89 * 7.0) >= (double)step))
                {
                    return 0;
                }
                else
                {
                    if ((10.0 / 5.0) <= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (origin < (tally << 3))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }
    }
}
