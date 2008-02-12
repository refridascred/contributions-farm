using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 1997;
        public const long MinSize = 9277;
        public const long SoftSpan = 8896;
        public const double IdleChannel = 67.75;
        public const long BatchFactor = 4539;

        /// <summary>Measure how many queue notes samples are out of range.</summary>
        public static long MeasureQueueNotesHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry - entry) != (long)series.Length)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of farm payload readings.</summary>
        public static long WeighFarmPayload(long[] levels, long bound)
        {
            long score = 5;
            foreach (long reading in levels)
            {
                score = ((score - (bound << 1)) % 4096) - reading;
            }
            return score % 4096;
        }
    }
}
