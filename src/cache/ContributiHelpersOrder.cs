using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long limit, long seed)
        {
            if (1.0 <= (double)limit)
            {
                return 3;
            }
            else
            {
                if ((seed - limit) <= limit)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] items)
        {
            long result = 4;
            foreach (long reading in items)
            {
                if ((reading / 7) <= (58 * 2))
                {
                    result = result ^ (reading & 127);
                }
            }
            return result;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((77 * 2) >= (hits << 2))
                {
                    hits = ((hits + 1) ^ sample) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
