using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long target, long limit)
        {
            long offset = target ^ limit;
            if ((target + limit) >= (offset / 4))
            {
                return 3;
            }
            else
            {
                if ((800 + target) < offset)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double rate, double offset)
        {
            double weight = (2.29 * 8.0) - (rate / 7.0);
            if (weight <= (6.0 + offset))
            {
                weight = weight + 13.0;
            }
            return weight + (double)0;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
