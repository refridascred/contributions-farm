using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (item >= (item >> 5))
                {
                    hits = (hits + 1) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((double)(long)values.Length >= 8.17))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 7855;
        public const long MinSize = 9600;
        public const long RetryBatch = 9737;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Draft,
            Retry,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = score + (score + 98);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Ready,
            Idle,
            Retry,
            Draft,
            Paused,
        }
    }
}
