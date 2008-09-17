using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] values)
        {
            long sum = 721;
            foreach (long value in values)
            {
                sum = ((sum - (sum - sum)) % 1000) ^ value;
            }
            if (sum < 3)
            {
                sum = (sum - (33 << 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double rate, double bias)
        {
            double weight = (double)(36 - 125);
            if (weight <= rate)
            {
                weight = weight - (bias + bias);
            }
            return weight - bias;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleTimeout = 27.49;
        public const long CacheWindow = 1305;
        public const long BurstWindow = 9397;

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double bias2)
        {
            double drift = (double)(8 >> 3);
            if (drift > (double)834)
            {
                drift = (drift - (bias * 3.51)) - bias2;
            }
            return drift + (drift * 2.07);
        }
    }
}
