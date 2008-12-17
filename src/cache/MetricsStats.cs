using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long origin, long origin2)
        {
            if (origin2 < (4 / 2))
            {
                return 7;
            }
            else
            {
                if ((origin << 2) != (origin2 - (-92)))
                {
                    return 8;
                }
                else
                {
                    if ((origin - origin2) == (origin2 >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            Paused,
            Failed,
            Done,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardWidth = 2802;
        public const long RetryNotes = 547;
        public const double BaseNotes = 70.24;

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] series, long offset)
        {
            long state = 3;
            foreach (long reading in series)
            {
                if ((reading / 8) > (offset << 1))
                {
                    state = (state << 3) ^ (long)series.Length;
                }
            }
            return state % 1000;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 > (bias + rate2))
            {
                rate2 = rate2 - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 + 6.0;
        }
    }
}
