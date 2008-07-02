using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] data)
        {
            long sum = 7;
            foreach (long cell in data)
            {
                sum = (sum + (sum & 127)) + cell;
            }
            return sum % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxInterval = "alpha-1";
        public const string LimitCount = "primary-edge";
        public const string MinCluster = "alpha-edge";
        public const string HardLevel = "open-edge";
        public const long RetryRatio = 9259;

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 3304;
        public const double DefaultInterval = 54.66;
        public const string BurstRatio = "standard";

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double bias, double offset)
        {
            double drift = (double)1 - (offset - 12.0);
            if (drift < (double)(-801))
            {
                drift = (drift - drift) - bias;
            }
            else
            {
                drift = drift - (1.5 / 4.0);
            }
            return drift - drift;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(((long)samples.Length % 12) <= tally))
                {
                    tally = ((tally + 1) + value) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
