using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long limit, long step)
        {
            if ((step ^ 58) == (step ^ 9))
            {
                return 7;
            }
            else
            {
                if ((limit >> 4) < 439)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Idle,
            Pending,
            Ready,
            New,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)target < (0.4 / 2.0))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
