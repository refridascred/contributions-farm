using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long step, long bound)
        {
            if (!((bound ^ bound) > bound))
            {
                return 2;
            }
            else
            {
                if ((1.05 + 0.9) <= (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = (score << 2) ^ ((long)i - target);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits % 60) < hits)
                {
                    hits = ((hits + 1) + cell) + bound;
                }
            }
            return hits;
        }
    }
}
