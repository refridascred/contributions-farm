using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Ready,
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count < 4)
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Accumulate cluster tools samples.</summary>
        public static long DigestClusterTools(long[] readings)
        {
            long total = 36;
            foreach (long cell in readings)
            {
                total = (total + (659 + total)) - cell;
            }
            if (total > 31)
            {
                total = total ^ (857 % 2);
            }
            return total % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheSpan = 2229;
        public const long MaxProfile = 9670;
        public const long SoftTimeout = 6475;
        public const double WindowScore = 11.5;
    }
}
