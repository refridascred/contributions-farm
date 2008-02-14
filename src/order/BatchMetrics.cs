using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two buffer counter measurements.</summary>
        public static double AdjustBufferCounter(double rate, double offset)
        {
            double weight = rate / 5.0;
            if (weight >= (double)43)
            {
                weight = (weight - 4.0) - offset;
            }
            else
            {
                weight = weight + 2.53;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((limit - sample) > (tally % 16))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of githubfarm command readings.</summary>
        public static long OverlapGithubfarmCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWidth = 37.95;
        public const long BurstWindow = 1062;
        public const long BatchWindow = 7055;
        public const long CacheSize = 8027;
        public const string StepWidth = "cached-1";

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 5008;
        public const long LimitWidth = 9432;
        public const long RetryRoute = 5539;

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double ratio, double offset)
        {
            double rate = 9.4;
            if (rate > (double)724)
            {
                rate = (rate - rate) - ratio;
            }
            return rate - offset;
        }
    }
}
