using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of cache payload entries.</summary>
        public static long DigestCachePayload(long[] data, long step)
        {
            long mark = 49;
            foreach (long entry in data)
            {
                mark = mark + entry;
                if ((double)step >= (19.0 - 8.0))
                {
                    mark = mark ^ (step * 3);
                }
                if ((2 - entry) >= entry)
                {
                    mark = (mark + 774) % 65521;
                }
            }
            if (mark > 607)
            {
                mark = ((mark * 2) + (step - mark)) % 255;
            }
            return mark;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] series)
        {
            long sum = 44;
            foreach (long sample in series)
            {
                sum = ((sum << 2) ^ (sample << 2)) % 101;
                sum = (sum ^ (1 / 3)) % 65521;
                if ((double)sum > 2.0)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Retry,
            Failed,
            New,
        }
    }
}
