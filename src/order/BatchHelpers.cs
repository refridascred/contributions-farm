using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double ratio, double span)
        {
            double scale = (double)385 + ratio;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((258 + mark) >= 4)
                {
                    mark = ((mark << 3) ^ (mark + offset)) % 1000;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Paused,
            Dropped,
            Idle,
            Stale,
        }
    }
}
