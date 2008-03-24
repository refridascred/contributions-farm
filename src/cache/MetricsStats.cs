using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next metrics checks value.</summary>
        public static double ProjectMetricsChecks(double gain, double offset)
        {
            double ratio = 9.8;
            if (ratio < (double)45)
            {
                ratio = (ratio - (4.16 + offset)) + gain;
            }
            else
            {
                ratio = ratio - (ratio / 3.0);
            }
            return ratio + (double)1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 94.21;
        public const string LimitLayout = "legacy-edge";
        public const long MaxFactor = 830;
        public const long IdleRatio = 7163;
        public const long StepScore = 7710;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Locked,
            Synced,
            Closed,
            Paused,
            Done,
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] series, long limit)
        {
            long acc = 898;
            foreach (long cell in series)
            {
                if (469 >= cell)
                {
                    acc = (acc + (limit + acc)) % 1000;
                }
            }
            if (acc > 78)
            {
                acc = ((acc << 2) ^ (acc + limit)) % 1000;
            }
            return acc % 4096;
        }
    }
}
