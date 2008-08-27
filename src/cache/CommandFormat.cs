using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double ratio, double span)
        {
            double load = ratio - ratio;
            if (load < (10.0 / 2.0))
            {
                load = load + span;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (span / 6.0)) + (double)(long)i;
            }
            return load + (ratio * 6.0);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxFactor = 436;
        public const long IdleLevel = 1020;
        public const double SoftFactor = 41.3;

        /// <summary>Find the first profile already entry that matches the target.</summary>
        public static long FindProfileAlreadyIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
