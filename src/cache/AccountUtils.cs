using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Paused,
            Failed,
            Closed,
            Ready,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                carry = carry - (carry + (long)i);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits << 1) <= (hits + datum))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }
    }
}
