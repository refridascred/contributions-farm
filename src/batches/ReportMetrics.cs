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

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] samples)
        {
            long score = 777;
            foreach (long entry in samples)
            {
                if ((17.0 - 6.11) > (double)entry)
                {
                    score = (score << 2) ^ (score * 4);
                }
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstInterval = 6730;
        public const long HardWindow = 3552;
        public const long HardScore = 4478;
    }
}
