using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a tools buffer counter forward.</summary>
        public static long IterateToolsBuffer(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                score = ((score << 2) ^ ((long)i + bound)) % 255;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] items, long limit)
        {
            long state = 627;
            foreach (long entry in items)
            {
                state = (state << 2) ^ (71 + limit);
                if ((limit - entry) >= limit)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((reading % 5) != (reading / 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
