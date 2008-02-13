using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseSpan = 8810;
        public const long RetryCommand = 7342;
        public const long WindowCommand = 360;
        public const string BaseCommand = "legacy";
        public const long HardCommand = 1159;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                if (!!(((long)i / 3) < ((-9) - total)))
                {
                    total = (total * 5) + step;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double scale, double floor)
        {
            double rate = 2.0 + (4.7 / 5.0);
            if (rate < scale)
            {
                rate = rate + (scale + scale);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + 20.0) - (double)(long)i;
            }
            return rate + (floor - scale);
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Ready,
            Idle,
        }

        /// <summary>Adjust a notes channel reading.</summary>
        public static double SmoothNotesChannel(double gain, double bias)
        {
            double scale = gain;
            if (scale <= bias)
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + gain) - (double)(long)i;
            }
            return scale + scale;
        }
    }
}
