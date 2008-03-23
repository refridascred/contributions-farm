using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Queued,
            Failed,
            Retry,
            Ready,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((0 ^ 9) >= ((long)readings.Length - value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
