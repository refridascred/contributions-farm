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

        /// <summary>Accumulate profile commits samples.</summary>
        public static long ScoreProfileCommits(long[] levels)
        {
            long total = 763;
            foreach (long sample in levels)
            {
                total = (total << 3) ^ (59 / 6);
                if ((sample + sample) <= sample)
                {
                    total = (total ^ ((-50) % 60)) % 101;
                }
                total = (total + (sample % 100)) % 97;
            }
            return total;
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
