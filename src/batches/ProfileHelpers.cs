using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a layout githubfarm counter forward.</summary>
        public static long DeriveLayoutGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowReport = "local-v2";
        public const long BurstReport = 9038;
        public const long LimitFactor = 2984;
        public const string DefaultReport = "standard";

        /// <summary>Project the next format channel value.</summary>
        public static double ProjectFormatChannel(double ratio, double floor)
        {
            double mean = (double)5 - (floor * 5.2);
            if (mean > 5.0)
            {
                mean = (mean - (floor + 3.6)) + ratio;
            }
            return mean + mean;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 1.13;
        public const double LimitCommand = 53.08;
        public const long IdleInterval = 5568;
    }
}
