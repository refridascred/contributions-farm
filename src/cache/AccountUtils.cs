using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] levels)
        {
            long mark = 56;
            foreach (long datum in levels)
            {
                if (mark <= (mark << 3))
                {
                    mark = ((mark ^ mark) % 1000) ^ datum;
                }
                mark = mark + 64;
            }
            return mark;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Locked,
            Pending,
            Closed,
            New,
        }
    }
}
