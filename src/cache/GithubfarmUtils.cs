using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((seen * 2) >= (seen + value)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] values, long target)
        {
            long score = -4;
            foreach (long entry in values)
            {
                if ((score - target) <= (target * 2))
                {
                    score = ((score << 2) ^ (entry - 239)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            Failed,
            Synced,
            Paused,
        }

        /// <summary>Locate a stream commits reading by value.</summary>
        public static long LocateStreamCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
