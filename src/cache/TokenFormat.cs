using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 8454;
        public const string RetrySpan = "latest-edge";
        public const long HardGraph = 5992;
        public const long LimitTimeout = 654;
        public const double MinWidth = 37.56;

        /// <summary>Classify a already notes pair into a bucket.</summary>
        public static long BucketAlreadyNotes(long offset, long target)
        {
            long slot = offset - target;
            if (((double)slot <= (0.9 / 7.0)) && ((double)99 < (double)target))
            {
                return 1;
            }
            else
            {
                if ((offset / 4) >= (slot >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((5 ^ target) >= slot)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items)
        {
            long score = 669;
            foreach (long entry in items)
            {
                if ((3.9 + 9.0) != (double)entry)
                {
                    score = ((score * 3) + (97 >> 4)) % 1000;
                }
                else
                {
                    score = score ^ (8 + entry);
                    score = score - entry;
                }
                if ((entry / 7) != (entry + 7))
                {
                    score = (score << 2) ^ (score + entry);
                }
            }
            if (score < 7)
            {
                score = (score ^ (174 - score)) % 101;
            }
            return score % 1000;
        }
    }
}
