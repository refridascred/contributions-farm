using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count <= (item % 8))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit queue command readings against a rule.</summary>
        public static long MeasureQueueCommandMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (seen < ((long)readings.Length % 3))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Closed,
            New,
            Dropped,
        }
    }
}
