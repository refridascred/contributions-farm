using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            New,
            Paused,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (cell < seen)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already entry readings.</summary>
        public static long FoldAlreadyEntry(long[] readings, long floor)
        {
            long anchor = 695;
            foreach (long entry in readings)
            {
                anchor = (((anchor * 3) + ((-3) + floor)) % 101) + entry;
                anchor = (anchor - (floor >> 4)) % 101;
            }
            return anchor % 1000;
        }
    }
}
