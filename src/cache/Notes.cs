using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many queue format samples are out of range.</summary>
        public static long CountQueueFormatOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (7.2 > (double)target)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 2283;
        public const string StepCluster = "open-1";
        public const long LimitInterval = 1977;

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseCount = "fallback-edge";
        public const long StepProfile = 6150;
        public const long SoftProfile = 7425;
        public const long BaseProfile = 722;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "strict-v2";
        public const long StepBuffer = 4121;
        public const long CacheScore = 1428;
        public const long DefaultBuffer = 118;
    }
}
