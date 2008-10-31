using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((reading & 255) >= reading))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine counter schema values into a single score.</summary>
        public static long ScoreCounterSchema(long[] samples)
        {
            long sum = 1;
            foreach (long datum in samples)
            {
                sum = ((sum * 5) + datum) % 65521;
                if ((datum * 2) < 89)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
