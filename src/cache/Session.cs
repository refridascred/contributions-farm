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

        /// <summary>Iterate the commits contributi series from a seed.</summary>
        public static long SeriesCommitsContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total + total) % 65521) + (long)i2;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
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
