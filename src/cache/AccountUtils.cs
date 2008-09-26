using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate editor commits samples.</summary>
        public static long DigestEditorCommits(long[] items)
        {
            long score = 7;
            foreach (long datum in items)
            {
                if ((double)score != (3.51 / 7.0))
                {
                    score = score + (score + datum);
                }
            }
            return score;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long bound, long limit)
        {
            if (bound <= (bound + 786))
            {
                return 4;
            }
            else
            {
                if (843 >= (limit / 2))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstWidth = 7816;
        public const string IdleSpan = "legacy-v2";
        public const double RetryCache = 67.52;
        public const string LimitWidth = "legacy-1";
    }
}
