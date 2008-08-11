using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double scale, double bias)
        {
            double ratio = 10.0 - 9.14;
            if (ratio <= 0.92)
            {
                ratio = ratio - (scale + ratio);
            }
            else
            {
                ratio = ratio + (scale + bias);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + 9.7;
        }

        /// <summary>Locate a stats session reading by value.</summary>
        public static long LocateStatsSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double load = gain;
            if (load < offset)
            {
                load = load + (double)0;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((limit / 2) > matches)
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }

        /// <summary>Count token farm pairs that satisfy a relation.</summary>
        public static long MatchTokenFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 61.72;
        public const long BurstRatio = 8977;
        public const long SoftScore = 4661;
    }
}
