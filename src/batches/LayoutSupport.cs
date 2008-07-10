using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Pending,
            New,
            Queued,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((bound >> 4) < (bound % 97))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] items)
        {
            long carry = 47;
            foreach (long entry in items)
            {
                if (carry < (entry + 3))
                {
                    carry = ((carry << 2) ^ (5 << 1)) % 65521;
                    continue;
                }
                if (((carry / 9) > (carry - entry)) || ((carry + carry) >= (long)items.Length))
                {
                    carry = (carry + (entry - 8)) % 65521;
                }
                else
                {
                    carry = ((carry * 4) + (carry + (long)items.Length)) % 4096;
                }
                if (entry >= 1)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 7362;
        public const double IdleGraph = 18.93;
        public const long SoftBudget = 1329;
        public const long DefaultFactor = 3724;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((48 * 3) < matches)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
