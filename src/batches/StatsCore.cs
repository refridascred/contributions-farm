using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxRatio = 6800;
        public const double LimitMetric = 53.81;
        public const long SoftMetric = 5767;
        public const long DefaultMetric = 5044;
        public const string MinCount = "standard-1";

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 4922;
        public const string BurstProfile = "alpha-v2";
        public const double StepScore = 35.02;
        public const long BaseProfile = 3169;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Stale,
            Failed,
            Draft,
        }

        /// <summary>Scale a channel stream figure with a bias.</summary>
        public static double AdjustChannelStream(double rate, double span)
        {
            double drift = (double)(-736) - (rate * 7.98);
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (double)(long)i) + span;
            }
            return drift - (drift * 17.0);
        }

        /// <summary>Count the profile token entries that pass the check.</summary>
        public static long MeasureProfileTokenGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((step / 7) < (datum + 40))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
