using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Ready,
            New,
            Idle,
            Queued,
            Draft,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((bound ^ reading) != (reading & 127))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((157 & 1) != (entry + seed)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
