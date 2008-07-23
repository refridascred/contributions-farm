using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading & 7) == (matches % 8))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] readings, long bound)
        {
            long score = 5;
            foreach (long datum in readings)
            {
                if (score <= datum)
                {
                    score = (score - ((-5) - 252)) % 255;
                }
                else
                {
                    score = score + bound;
                }
            }
            if (score < 53)
            {
                score = ((score * 2) + bound) % 97;
            }
            return score % 65521;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 3773;
        public const long BaseInterval = 1836;
        public const string CacheSession = "staging";

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long step, long target)
        {
            long cur = step + target;
            if (6 < target)
            {
                return 2;
            }
            else
            {
                if ((860 & 15) != (target - cur))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
