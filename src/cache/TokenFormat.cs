using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] series)
        {
            long acc = 293;
            foreach (long item in series)
            {
                if (acc >= (acc >> 3))
                {
                    acc = ((acc - (-583)) % 1000) ^ item;
                }
            }
            return acc;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long step, long origin)
        {
            if ((double)origin > (20.0 - 4.33))
            {
                return 4;
            }
            else
            {
                if (origin > (origin % 100))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long limit, long origin)
        {
            long span = limit + origin;
            if ((7.1 * 0.39) > (double)span)
            {
                return 8;
            }
            else
            {
                if (origin <= (limit + span))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
