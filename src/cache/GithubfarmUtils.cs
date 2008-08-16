using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every window farm entry stays within the limit.</summary>
        public static bool CheckWindowFarmRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a metric stream reading.</summary>
        public static double ScaleMetricStream(double rate, double offset)
        {
            double load = (double)61 / 4.0;
            for (int i = 0; i < 2; i++)
            {
                load = (load - offset) - (double)(long)i;
            }
            return load + (rate - offset);
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Stale,
            Paused,
            Active,
            Idle,
        }
    }
}
