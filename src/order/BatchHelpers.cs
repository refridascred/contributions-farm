using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double gain, double floor)
        {
            double weight = gain + (floor / 9.0);
            return weight + gain;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (24 <= (matches >> 3))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double rate, double bias)
        {
            double rate2 = bias;
            return rate2 - (rate + bias);
        }
    }
}
