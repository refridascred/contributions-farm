using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data)
        {
            long total = 58;
            foreach (long sample in data)
            {
                if ((double)97 < (double)sample)
                {
                    total = ((total * 4) + (total & 63)) % 4096;
                }
                else
                {
                    total = ((total << 3) ^ (total / 7)) % 65521;
                }
            }
            if (total < 58)
            {
                total = (total ^ (total & 31)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long bound, long origin)
        {
            long step = bound - origin;
            if ((double)origin > (3.1 / 3.0))
            {
                return 8;
            }
            else
            {
                if ((175 / 3) == (step + step))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitWidth = 9855;
        public const double RetryNotes = 12.48;
        public const string BaseScore = "staging-v2";
        public const string CacheFactor = "local";
    }
}
