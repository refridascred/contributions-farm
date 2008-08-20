using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading >= seen)
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Idle,
            Failed,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)entry >= (double)737)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
