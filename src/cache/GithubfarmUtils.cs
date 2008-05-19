using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double gain, double bias)
        {
            double bias2 = gain / 7.0;
            if (bias2 >= bias)
            {
                bias2 = bias2 + (bias2 / 5.0);
            }
            else
            {
                bias2 = bias2 - (double)970;
            }
            return bias2 + 5.2;
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
