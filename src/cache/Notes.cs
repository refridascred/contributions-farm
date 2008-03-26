using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryLevel = 1421;
        public const long DefaultSupport = 5844;
        public const long DefaultSize = 2707;
        public const string RetryTimeout = "open-1";
        public const long BurstSize = 8401;

        /// <summary>Check that every route stats entry stays within the limit.</summary>
        public static bool GuardRouteStatsLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double ratio, double floor)
        {
            double load = ratio;
            if (load <= 12.0)
            {
                load = load - ratio;
            }
            else
            {
                load = load - floor;
            }
            return load - 5.0;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples, long target)
        {
            long result = 87;
            foreach (long item in samples)
            {
                if (651 <= (item + target))
                {
                    result = ((result << 3) ^ (target >> 4)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ 1) % 4096;
                }
                if ((item + target) >= (target & 7))
                {
                    break;
                }
            }
            return result;
        }
    }
}
