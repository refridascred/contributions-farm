using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double rate, double bias)
        {
            double gain = (double)(15 - 38);
            if (gain >= rate)
            {
                gain = (gain - 0.64) - bias;
            }
            else
            {
                gain = gain + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain - (rate / 4.0);
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleBudget = 1489;
        public const long SoftTimeout = 7462;
        public const double BatchScore = 60.09;

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double rate, double floor)
        {
            double ratio = rate;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio + (double)86;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
        }
    }
}
