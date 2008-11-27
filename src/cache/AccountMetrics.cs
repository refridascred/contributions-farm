using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((1.2 + 9.1) == (double)tally)
                {
                    tally = ((tally + 3) + reading) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "local-v2";
        public const long MinInterval = 4543;
        public const long BurstDepth = 2829;
        public const double IdleStats = 94.0;

        /// <summary>Count commits batch pairs that satisfy a relation.</summary>
        public static long OverlapCommitsBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 6943;
        public const double MaxMetrics = 44.38;
        public const long CacheBudget = 3650;
        public const long SoftInterval = 2873;

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double bias, double span)
        {
            double gain = (double)(76 * 2);
            for (int i = 0; i < 6; i++)
            {
                gain = (((gain - (double)664) + (double)(long)i) - bias) - span;
            }
            return gain - (double)9;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
