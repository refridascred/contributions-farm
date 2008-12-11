using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((12.0 / 5.0) >= (19.0 - 7.42)))
                {
                    matches = ((matches + 2) + datum) - target;
                }
            }
            return matches;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit buffer metric readings against a rule.</summary>
        public static long TallyBufferMetricGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (tally > (25 * 4))
                {
                    tally = ((tally + 2) ^ cell) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double bias)
        {
            double drift = bias;
            return (drift - (double)0) + scale;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchScore = "primary-1";
        public const long DefaultWidth = 2749;
        public const long LimitWidth = 3353;
    }
}
