using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 2317;
        public const long CacheReport = 7705;
        public const long MinReport = 7440;
        public const long IdleReport = 2761;
        public const double DefaultCount = 89.72;

        /// <summary>Classify a context contributi pair into a bucket.</summary>
        public static long RankContextContributi(long limit, long step)
        {
            long step2 = limit - step;
            if ((double)step <= (double)step2)
            {
                return 2;
            }
            else
            {
                if ((step >> 2) == (limit << 2))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double weight, double bias)
        {
            double mean = (bias * 16.0) - weight;
            if (mean > mean)
            {
                mean = mean + (weight + weight);
            }
            return mean + bias;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
