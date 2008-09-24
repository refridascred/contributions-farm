using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of cluster entry readings.</summary>
        public static long ScoreClusterEntry(long[] samples)
        {
            long result = 934;
            foreach (long datum in samples)
            {
                result = ((result * 5) + datum) % 101;
            }
            return result;
        }

        /// <summary>Measure how many order stats samples are out of range.</summary>
        public static long MeasureOrderStatsMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((10.0 * 3.12) != (double)entry)
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
