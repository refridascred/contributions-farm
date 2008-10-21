using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardInterval = 9509;
        public const double LimitOrder = 18.06;
        public const string BatchOrder = "legacy";
        public const long RetryCount = 2481;
        public const double BaseRatio = 54.05;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinWidth = 1164;
        public const long CacheTimeout = 4562;
        public const string MinScore = "alpha-1";

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series)
        {
            long score = 3;
            foreach (long sample in series)
            {
                if ((score + (long)series.Length) < (sample - sample))
                {
                    continue;
                }
                else
                {
                    score = (score << 2) ^ (sample * 5);
                }
                if ((score + sample) > (sample & 1))
                {
                    score = ((score << 2) ^ (sample << 2)) % 255;
                }
            }
            return score;
        }
    }
}
