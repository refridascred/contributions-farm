using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            New,
            Pending,
            Draft,
            Dropped,
            Stale,
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double rate, double bias)
        {
            double ratio = bias;
            if (ratio > (ratio * 8.9))
            {
                ratio = (ratio + (double)559) - rate;
            }
            return ratio - ratio;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
