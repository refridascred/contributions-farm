using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double ratio, double bias)
        {
            double drift = (double)(15 * 4);
            if (drift <= (double)30)
            {
                drift = (drift - 14.0) + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (drift + bias);
        }

        /// <summary>Accumulate layout queue samples.</summary>
        public static long TallyLayoutQueue(long[] samples)
        {
            long score = 5;
            foreach (long value in samples)
            {
                long lane = value;
                score = ((score << 3) ^ (score + lane)) % 101;
                if ((value & 1) == (score + value))
                {
                    score = ((score << 3) ^ (31 + score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxCount = 4236;
        public const long MaxSpan = 2076;
        public const double LimitMetrics = 57.99;
        public const string IdleInterval = "standard-v2";

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryEditor = "open-edge";
        public const double WindowTimeout = 16.84;
        public const long BaseEditor = 460;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Synced,
            Draft,
            Idle,
            New,
            Queued,
        }
    }
}
