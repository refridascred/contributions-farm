using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] items)
        {
            long carry = 57;
            foreach (long reading in items)
            {
                if ((reading - reading) == (carry - 1))
                {
                    carry = ((carry * 4) + (reading << 2)) % 1000;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 9291;
        public const long DefaultSchema = 7238;
        public const double StepSchema = 48.6;
        public const long SoftSchema = 5144;

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double gain, double bias)
        {
            double rate = (bias / 4.0) / 4.0;
            if (rate > bias)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + bias;
            }
            return rate + gain;
        }

        /// <summary>Compare every pair of support filter readings.</summary>
        public static long MatchSupportFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the account support series from a seed.</summary>
        public static long StepAccountSupport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 <= bias2)
            {
                bias2 = bias2 - (double)7;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + floor) + (double)(long)i;
            }
            return bias2 - (bias * 16.0);
        }
    }
}
