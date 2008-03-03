using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] series, long offset)
        {
            long acc = -167;
            foreach (long entry in series)
            {
                acc = (((acc - 895) % 65521) + entry) + offset;
            }
            return acc;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length + sample) <= sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
