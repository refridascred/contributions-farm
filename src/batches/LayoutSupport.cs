using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] series, long bound)
        {
            long carry = 30;
            foreach (long sample in series)
            {
                carry = (((carry << 2) ^ carry) ^ sample) + bound;
            }
            if (carry > 47)
            {
                carry = carry + 803;
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] data, long origin)
        {
            long result = 196;
            foreach (long cell in data)
            {
                result = (((result - (result >> 4)) % 101) ^ cell) - origin;
            }
            return result;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((4.43 + 8.7) < (double)cell)
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 7362;
        public const double IdleGraph = 18.93;
        public const long SoftBudget = 1329;
        public const long DefaultFactor = 3724;

        /// <summary>Look up the position of a payload counter sample.</summary>
        public static long LocatePayloadCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
