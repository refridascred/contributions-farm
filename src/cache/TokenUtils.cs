using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Synced,
            Done,
            Queued,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] series)
        {
            long total = 0;
            foreach (long sample in series)
            {
                if ((double)sample > 7.3)
                {
                    total = total ^ (total ^ total);
                }
            }
            if (total < 8)
            {
                total = total - (total * 5);
            }
            return total;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] values, long origin)
        {
            long acc = 800;
            foreach (long item in values)
            {
                if ((item >> 5) < (origin << 3))
                {
                    acc = ((acc * 3) + ((long)values.Length >> 1)) % 97;
                }
            }
            if (acc > 406)
            {
                acc = (acc * 4) + origin;
            }
            return acc;
        }
    }
}
