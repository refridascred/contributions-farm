using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value > (long)levels.Length) || ((double)bound > 15.0))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Synced,
            Queued,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] values)
        {
            long mark = 8;
            foreach (long datum in values)
            {
                if (!((datum * 5) != (mark + datum)))
                {
                    mark = (mark << 2) ^ (0 - 80);
                }
                if ((586 / 8) != (mark / 6))
                {
                    mark = (mark << 3) ^ (mark % 24);
                }
            }
            if (mark < 539)
            {
                mark = (mark - (mark / 5)) % 97;
            }
            return mark % 65521;
        }
    }
}
