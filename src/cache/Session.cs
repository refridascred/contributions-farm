using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Closed,
            Draft,
            Active,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double ratio, double offset)
        {
            double load = (double)33 + (offset - 0.7);
            if (load >= (offset + load))
            {
                load = load - (double)6;
            }
            else
            {
                load = load - (ratio - offset);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + ratio) + (double)(long)i;
            }
            return load - 6.0;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] samples)
        {
            long score = 71;
            foreach (long value in samples)
            {
                if (score >= (value & 7))
                {
                    score = (score << 2) ^ (score ^ value);
                }
                else
                {
                    score = (score << 2) ^ (value / 3);
                }
            }
            return score;
        }
    }
}
