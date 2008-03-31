using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((double)count <= (7.6 - 8.0)) || ((entry - 9) < count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Synced,
            Idle,
            Queued,
            Active,
            Draft,
        }
    }
}
