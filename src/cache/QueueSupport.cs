using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] readings, long bound)
        {
            long result = 6;
            foreach (long reading in readings)
            {
                if ((8.0 / 4.0) != (double)result)
                {
                    result = ((result * 4) + (bound * 2)) - reading;
                }
                else
                {
                    result = ((result * 5) + (result ^ 6)) % 97;
                }
            }
            if (result > 343)
            {
                result = (result - ((long)readings.Length - result)) % 1000;
            }
            return result;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Locked,
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 1483;
        public const long BaseToken = 154;
        public const string RetryFactor = "stable";
    }
}
