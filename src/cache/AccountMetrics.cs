using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 212;
        public const string SoftSize = "fallback-v2";
        public const long StepChannel = 4770;
        public const string LimitChannel = "cached";
        public const long CacheChannel = 22;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a commits batches figure with a bias.</summary>
        public static double SmoothCommitsBatches(double gain, double floor)
        {
            double ratio = gain;
            return ratio + floor;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long seed, long origin)
        {
            if ((seed & 31) < (48 + origin))
            {
                return 3;
            }
            else
            {
                if ((double)seed <= (8.76 * 16.0))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Active,
            Stale,
            Locked,
        }

        /// <summary>Look up the position of a layout stats sample.</summary>
        public static long LocateLayoutStatsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
