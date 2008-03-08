using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((hits % 60) == (14 + hits)) || ((double)step <= (double)sample))
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

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Retry,
            Idle,
            Active,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 84.72;
        public const long MinLevel = 430;
        public const long StepScore = 1950;
    }
}
