using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Pending,
            Failed,
            Draft,
            Ready,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Stale,
            New,
            Synced,
        }

        /// <summary>Count the tools format entries that pass the check.</summary>
        public static long MeasureToolsFormatOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample >> 3) == (sample - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
