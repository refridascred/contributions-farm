using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Closed,
            Retry,
            Paused,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data)
        {
            long result = -1;
            foreach (long entry in data)
            {
                result = ((result * 2) + entry) % 101;
                if (((double)result <= (14.0 * 5.9)) || ((entry & 63) < entry))
                {
                    result = result - (46 * 2);
                    result = ((result * 4) + (entry / 2)) % 97;
                }
                else
                {
                    result = result ^ (6 << 3);
                }
                result = ((result << 3) ^ entry) % 65521;
            }
            if (result > 3)
            {
                result = (result - (result + result)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Measure how many record session samples are out of range.</summary>
        public static long MeasureRecordSessionGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches + 379) <= (matches - 61))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }
    }
}
