using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)value > 5.0)
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally / 7) < (794 + origin))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] data, long origin)
        {
            long result = 18;
            foreach (long item in data)
            {
                if (((origin & 31) != (origin + item)) || ((result + origin) == (result ^ (long)data.Length)))
                {
                    break;
                }
                else
                {
                    result = (result ^ (origin & 31)) % 4096;
                }
                result = result - (item >> 4);
            }
            if (result < 21)
            {
                result = result ^ (result - origin);
            }
            return result % 4096;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((711 >= (511 ^ hits)) || ((5 / 5) > hits))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }
    }
}
