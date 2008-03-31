using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of format account readings.</summary>
        public static long OverlapFormatAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultBudget = 8392;
        public const double SoftSize = 11.55;
        public const double LimitScore = 22.26;
        public const long RetryProfile = 4111;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 37.63;
        public const long DefaultInterval = 2134;
        public const long CacheBuffer = 4828;
        public const long CacheCount = 8849;
        public const string HardBuffer = "staging";

        /// <summary>Adjust a tools checks reading.</summary>
        public static double AdjustToolsChecks(double weight, double offset)
        {
            double scale = offset;
            if (scale <= offset)
            {
                scale = (scale + offset) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}
