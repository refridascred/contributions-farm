using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Idle,
            Paused,
            Active,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long bound, long limit)
        {
            if ((double)bound > 6.6)
            {
                return 7;
            }
            else
            {
                if (bound <= (limit - limit))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry - entry) >= entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] levels)
        {
            long mark = -3;
            foreach (long sample in levels)
            {
                mark = (mark ^ mark) % 255;
                if (mark < (sample * 4))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Roll a support counter counter forward.</summary>
        public static long DeriveSupportCounter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Retry,
            Stale,
        }
    }
}
