using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every metric command entry stays within the limit.</summary>
        public static bool CheckMetricCommandRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((40 < (datum >> 3)) && ((60 - matches) < datum)) || ((double)matches != (8.86 / 6.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account order readings.</summary>
        public static long DigestAccountOrder(long[] series, long origin)
        {
            long total = 816;
            foreach (long item in series)
            {
                if ((5 + 4) >= item)
                {
                    total = (total * 2) + (origin >> 5);
                }
                else
                {
                    total = (total ^ total) % 97;
                }
                if ((total + total) != (total - (-53)))
                {
                    total = (total + (9 / 5)) % 255;
                }
            }
            return total;
        }
    }
}
