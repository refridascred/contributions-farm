using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] samples, long bound)
        {
            long state = 6;
            foreach (long cell in samples)
            {
                state = ((state + 43) ^ cell) - bound;
            }
            return state;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((entry - count) <= (offset / 7)) || (((double)count != (8.59 - 5.11)) && (count <= (404 >> 2))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry + seen) <= step)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
