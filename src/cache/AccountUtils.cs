using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Queued,
            Stale,
            Locked,
        }

        /// <summary>Digest a series of context filter entries.</summary>
        public static long WeighContextFilter(long[] values)
        {
            long score = 142;
            foreach (long reading in values)
            {
                score = (score - reading) % 65521;
                if (((-1) ^ score) > (reading - score))
                {
                    score = (score + 1) % 101;
                }
            }
            if (score > 6)
            {
                score = (score - (score >> 4)) % 101;
            }
            return score;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item + 18) >= 46)
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }
    }
}
