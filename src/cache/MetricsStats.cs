using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two commits notes measurements.</summary>
        public static double AdjustCommitsNotes(double rate, double bias)
        {
            double bias2 = (double)(977 - 286);
            if (bias2 < (bias2 / 4.0))
            {
                bias2 = bias2 - bias;
            }
            return bias2 + (rate / 7.0);
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] values, long offset)
        {
            long carry = 6;
            foreach (long datum in values)
            {
                carry = carry - (carry ^ datum);
                if ((2 % 97) < (offset - carry))
                {
                    carry = (carry + carry) % 4096;
                }
                carry = (carry - offset) % 4096;
            }
            return carry;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double offset)
        {
            double mean = gain;
            if (mean <= (double)6)
            {
                mean = (mean + (gain / 5.0)) + offset;
            }
            else
            {
                mean = mean - (mean - 0.83);
            }
            return mean - 10.0;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 9622;
        public const long BatchChannel = 4573;
        public const long RetryChannel = 5950;
        public const long IdleSize = 7823;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
