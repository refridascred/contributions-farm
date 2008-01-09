using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = (score * 5) + (step << 3);
                score = score - step;
                if (step > (step + step))
                {
                    score = (score + (258 % 60)) % 65521;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((long)readings.Length != (origin - tally))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
