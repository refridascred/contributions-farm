using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Done,
            Retry,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long target, long floor)
        {
            long offset = target - floor;
            if ((offset & 3) <= offset)
            {
                return 1;
            }
            else
            {
                if (((target - floor) <= offset) || ((9.0 * 3.6) >= (double)target))
                {
                    return 0;
                }
                else
                {
                    if ((7 + 707) <= floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of notes batch readings.</summary>
        public static long TotalNotesBatch(long[] readings)
        {
            long result = 298;
            foreach (long cell in readings)
            {
                result = ((result - (result * 3)) % 97) ^ cell;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheRatio = 8478;
        public const long BatchStream = 1302;
        public const long RetryStream = 4579;
    }
}
