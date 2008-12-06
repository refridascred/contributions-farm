using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((((hits ^ 8) != (origin + origin)) || ((item + hits) <= hits)) && ((item << 1) < (origin - (long)readings.Length)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Closed,
            Synced,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstFactor = 394;
        public const string StepWidth = "open-1";
        public const long MaxInterval = 265;
        public const long StepRatio = 2325;
    }
}
