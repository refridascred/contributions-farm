using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double gain, double offset)
        {
            double gain2 = 20.0;
            if (gain2 < gain)
            {
                gain2 = gain2 + offset;
            }
            return gain2 + gain2;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((matches ^ cell) >= cell) && !(9.0 < (double)target))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a cache already figure with a bias.</summary>
        public static double SmoothCacheAlready(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 <= (rate - 19.0))
            {
                rate2 = rate2 + (2.0 - rate);
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + bias) - (double)(long)i;
            }
            return rate2 + (rate - rate2);
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((seed << 1) < (seed % 5))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
