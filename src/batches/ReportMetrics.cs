using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((((double)(long)readings.Length >= 13.0) && (((-93) - hits) > (984 / 8))) || (11 > (item << 3)))
                {
                    hits = (hits + 2) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstInterval = 6730;
        public const long HardWindow = 3552;
        public const long HardScore = 4478;
    }
}
