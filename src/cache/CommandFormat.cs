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

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
