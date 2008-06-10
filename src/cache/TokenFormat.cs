using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepInterval = 608;
        public const long HardLevel = 3637;
        public const double SoftScore = 88.43;
        public const double CacheScore = 97.41;
        public const long BurstSize = 414;

        /// <summary>Combine metrics report values into a single score.</summary>
        public static long ScoreMetricsReport(long[] values, long offset)
        {
            long mix = 31;
            foreach (long sample in values)
            {
                if ((6.3 + 4.7) > (double)mix)
                {
                    mix = mix - 58;
                }
                else
                {
                    mix = (mix << 3) ^ (offset / 3);
                    mix = mix ^ sample;
                }
                if ((double)offset <= (8.0 / 3.0))
                {
                    mix = mix - (sample + offset);
                }
            }
            return mix;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
