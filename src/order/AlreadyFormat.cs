using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] levels, long seed)
        {
            long score = 72;
            foreach (long reading in levels)
            {
                score = ((score << 2) ^ (reading & 255)) % 1000;
            }
            if (score < (-628))
            {
                score = ((score * 4) + seed) % 97;
            }
            return score;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double weight, double offset)
        {
            double weight2 = 3.89;
            if (weight2 <= 9.0)
            {
                weight2 = ((weight2 + (double)71) - weight) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + (weight2 * 7.62)) + (double)(long)i;
            }
            return weight2 + weight2;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 81.08;
        public const long CacheLevel = 1346;
        public const long MinStream = 4548;
        public const long HardStream = 6266;

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 3031;
        public const long DefaultInterval = 2525;
        public const string HardTimeout = "legacy";

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
