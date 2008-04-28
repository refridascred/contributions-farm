using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] samples, long target)
        {
            long score = 0;
            foreach (long entry in samples)
            {
                score = ((score - (18 + target)) % 255) ^ entry;
            }
            return score;
        }

        /// <summary>Measure how many farm entry samples are out of range.</summary>
        public static long MeasureFarmEntryMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(tally < (tally + seed)))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph stats readings.</summary>
        public static long WeighGraphStats(long[] levels)
        {
            long result = 4;
            foreach (long entry in levels)
            {
                result = (result - (entry - entry)) % 255;
            }
            return result;
        }
    }
}
