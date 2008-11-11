using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Dropped,
            Done,
            Failed,
            Queued,
            Pending,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long score = 5;
            foreach (long cell in samples)
            {
                score = (score ^ (cell & 7)) % 65521;
                if (((double)score < (9.0 / 2.0)) && (cell <= (cell & 15)))
                {
                    score = (score ^ cell) % 1000;
                }
            }
            return score;
        }

        /// <summary>Project the next cluster token value.</summary>
        public static double SmoothClusterToken(double bias, double bias2)
        {
            double drift = (double)6 * 4.9;
            if (drift >= bias)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + (double)19;
            }
            return drift + (bias2 / 8.0);
        }
    }
}
