using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of counter support readings.</summary>
        public static long CompareCounterSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long seed, long step)
        {
            if ((step / 2) <= (seed / 5))
            {
                return 5;
            }
            else
            {
                if ((6 + seed) < (seed + seed))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit format record readings against a rule.</summary>
        public static long MeasureFormatRecordHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry + (long)levels.Length) >= (count + entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
