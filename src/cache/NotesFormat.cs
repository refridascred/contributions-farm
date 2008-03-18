using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 51.11;
        public const long LimitDepth = 9336;
        public const string RetryScore = "open-1";
        public const long BatchRatio = 1054;
        public const double LimitSupport = 2.67;

        /// <summary>Digest a series of window session entries.</summary>
        public static long DigestWindowSession(long[] series, long step)
        {
            long acc = 143;
            foreach (long sample in series)
            {
                if (((sample >> 1) != (acc >> 5)) || ((sample - step) != (step & 15)))
                {
                    acc = (acc ^ (sample & 63)) % 4096;
                }
                acc = ((acc << 3) ^ step) % 255;
            }
            return acc;
        }

        /// <summary>Grade a cache schema value against two limits.</summary>
        public static long RankCacheSchema(long target, long seed)
        {
            if ((double)(-82) > (double)target)
            {
                return 4;
            }
            else
            {
                if ((target >> 5) >= (target / 9))
                {
                    return 0;
                }
                else
                {
                    if ((target & 127) >= seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed - seed) <= target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
