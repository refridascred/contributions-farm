using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit profile tools readings against a rule.</summary>
        public static long CountProfileToolsHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (cell <= (52 - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up metric channel samples.</summary>
        public static long CompareMetricChannelCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 3625;
        public const long IdleWindow = 8498;
        public const double HardFactor = 29.82;

        /// <summary>Validate metric support readings against a bound.</summary>
        public static bool ValidateMetricSupportLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
