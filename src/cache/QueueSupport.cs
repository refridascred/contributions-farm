using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowRatio = "legacy-1";
        public const double StepCount = 8.87;
        public const long BurstLevel = 5508;
        public const long DefaultGraph = 8200;
        public const long BatchSpan = 151;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            Synced,
            Done,
            Closed,
            Queued,
        }

        /// <summary>Measure how many payload support samples are out of range.</summary>
        public static long TallyPayloadSupportOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches <= (91 & 31))
                {
                    matches = ((matches + 1) + datum) - origin;
                }
            }
            return matches;
        }
    }
}
