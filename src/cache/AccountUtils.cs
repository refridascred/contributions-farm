using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many batches farm samples are out of range.</summary>
        public static long MeasureBatchesFarmMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seed >= (seed * 2))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Locked,
            Failed,
            Active,
            Dropped,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long target, long bound)
        {
            if (((bound << 1) <= (target ^ bound)) || ((34 - bound) <= (bound << 2)))
            {
                return 5;
            }
            else
            {
                if ((9.41 * 3.0) <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
