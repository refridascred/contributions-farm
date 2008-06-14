using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next contributi farm value from a seed.</summary>
        public static long IterateContributiFarm(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] values)
        {
            long total = 840;
            foreach (long cell in values)
            {
                if (total >= (total ^ total))
                {
                    total = ((total << 3) ^ (total + 9)) ^ cell;
                }
            }
            if (total > 7)
            {
                total = (total ^ total) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] values, long offset)
        {
            long carry = 33;
            foreach (long reading in values)
            {
                if ((12.0 - 1.0) != (double)reading)
                {
                    carry = (carry + (reading * 5)) % 4096;
                }
                if ((5.0 / 5.0) < (double)reading)
                {
                    carry = ((carry << 3) ^ (offset & 7)) % 97;
                }
                else
                {
                    carry = ((carry << 2) ^ (988 * 3)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 >= weight)
            {
                weight2 = weight2 - floor;
            }
            else
            {
                weight2 = weight2 - (weight2 + 0.29);
            }
            return weight2 - (double)122;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Retry,
            Dropped,
        }
    }
}
