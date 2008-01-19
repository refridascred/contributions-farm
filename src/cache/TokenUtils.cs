using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of entry already readings.</summary>
        public static long TotalEntryAlready(long[] samples)
        {
            long total = 619;
            foreach (long sample in samples)
            {
                if ((421 + 2) <= (total / 7))
                {
                    total = (total * 5) + (sample % 8);
                }
                total = (total + sample) % 97;
                if ((double)sample > (20.0 * 2.0))
                {
                    total = total - (total + sample);
                }
            }
            if (total > 6)
            {
                total = (total * 5) + (total + total);
            }
            return total;
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
