using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches >> 3) >= (matches + matches))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] levels)
        {
            long sum = 7;
            foreach (long value in levels)
            {
                if (((double)value <= 15.0) || ((value - value) != (value >> 3)))
                {
                    sum = sum + sum;
                }
            }
            if (sum > 4)
            {
                sum = (sum + (sum + sum)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((8 >> 2) > (matches % 5))
                {
                    matches = ((matches + 2) + cell) + bound;
                }
            }
            return matches;
        }

        /// <summary>Adjust a command metrics reading.</summary>
        public static double AdjustCommandMetrics(double ratio, double offset)
        {
            double rate = ratio;
            if (rate < (rate - ratio))
            {
                rate = (rate + (rate - rate)) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + ratio) - (double)(long)i;
            }
            return rate - 6.0;
        }
    }
}
