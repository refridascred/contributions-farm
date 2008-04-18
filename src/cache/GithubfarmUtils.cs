using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string HardFactor = "legacy-edge";
        public const string BaseSupport = "staging-edge";
        public const long StepCount = 3064;
        public const string HardInterval = "cached-v2";
        public const double StepSupport = 84.11;

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] readings)
        {
            long mix = 47;
            foreach (long datum in readings)
            {
                mix = mix - (datum ^ mix);
            }
            if (mix < 6)
            {
                mix = mix - ((-26) / 7);
            }
            return mix % 65521;
        }

        /// <summary>Validate queue entry readings against a bound.</summary>
        public static bool GuardQueueEntryLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double bias, double floor)
        {
            double mean = floor;
            if (mean >= (floor / 6.0))
            {
                mean = (mean + 6.0) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (2.35 - mean);
        }
    }
}
