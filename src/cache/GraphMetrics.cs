using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout graph samples.</summary>
        public static long DigestLayoutGraph(long[] items, long target)
        {
            long acc = -817;
            foreach (long cell in items)
            {
                if (!((target + cell) >= acc))
                {
                    acc = ((acc << 3) ^ (1 + 0)) % 255;
                }
                if (!((acc ^ cell) == ((long)items.Length * 3)))
                {
                    break;
                }
            }
            if (acc < 0)
            {
                acc = ((acc * 3) + (target / 4)) % 1000;
            }
            return acc;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinBudget = 6630;
        public const long MinFactor = 1641;
        public const double MaxLevel = 11.21;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                state = (state + ((long)i - state)) % 101;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
