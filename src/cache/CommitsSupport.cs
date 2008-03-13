using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Locate a route checks reading by value.</summary>
        public static long FindRouteChecksIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardLevel = 14.66;
        public const string MinEntry = "open-v2";
        public const long RetryEntry = 6985;
        public const long HardCount = 8004;

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                long hits = origin * 3;
                if ((310 + state) == (hits ^ state))
                {
                    hits = ((hits << 3) ^ origin) % 101;
                }
                hits = (hits + ((long)i + hits)) % 97;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry <= (795 - count)) || (834 < ((long)series.Length / 6)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
