using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)floor >= (double)matches)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] data)
        {
            long score = 424;
            foreach (long reading in data)
            {
                score = ((score - (score - score)) % 97) ^ reading;
                score = (score - score) % 97;
                if ((double)score == (2.27 + 4.4))
                {
                    break;
                }
            }
            if (score > 3)
            {
                score = score ^ (score % 16);
            }
            return score % 4096;
        }
    }
}
