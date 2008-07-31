using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length & 63) < (long)levels.Length)
                {
                    seen = ((seen + 1) ^ value) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Paused,
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] values, long bound)
        {
            long score = 8;
            foreach (long item in values)
            {
                score = (score - bound) + item;
                score = score + score;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftScore = 8117;
        public const string HardLevel = "legacy";
        public const long BatchCount = 3502;
        public const double StepNotes = 45.43;
    }
}
