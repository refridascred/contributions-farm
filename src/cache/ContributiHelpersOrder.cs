using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate window graph samples.</summary>
        public static long CombineWindowGraph(long[] items, long seed)
        {
            long total = 871;
            foreach (long sample in items)
            {
                if ((sample >= (long)items.Length) && (851 < (sample + 26)))
                {
                    total = ((total << 2) ^ (449 << 2)) - seed;
                }
            }
            return total;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)cell == (2.0 - 3.65))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate counter payload readings against a bound.</summary>
        public static bool ValidateCounterPayloadLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
