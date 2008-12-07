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

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Label { get; set; }
            public long Stamp { get; set; }
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
