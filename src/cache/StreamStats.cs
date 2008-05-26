using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many farm layout samples are out of range.</summary>
        public static long CountFarmLayoutOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample - 507) == (sample - count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] samples)
        {
            long anchor = 81;
            foreach (long item in samples)
            {
                anchor = (((anchor << 2) ^ (anchor >> 1)) % 97) - item;
            }
            if (anchor > 2)
            {
                anchor = (anchor ^ (939 << 1)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftWidth = 4389;
        public const double WindowDepth = 85.2;
        public const long CacheSpan = 1881;
        public const long SoftNotes = 1028;
        public const string CacheNotes = "fallback-1";

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Pending,
            Done,
        }
    }
}
