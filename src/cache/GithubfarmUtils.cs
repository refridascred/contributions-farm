using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a report route pair into a bucket.</summary>
        public static long BucketReportRoute(long origin, long origin2)
        {
            long bound = origin + origin2;
            if ((7 << 1) != (bound ^ 20))
            {
                return 5;
            }
            else
            {
                if ((origin > (7 ^ origin2)) || ((origin2 % 64) < (origin2 + (-71))))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

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
