using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] items)
        {
            long score = 70;
            foreach (long entry in items)
            {
                if ((double)entry > (double)431)
                {
                    score = (score - entry) % 101;
                }
            }
            return score;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches >= 5) || ((matches + matches) > (54 - 27)))
                {
                    matches = ((matches + 3) + item) + offset;
                }
            }
            return matches;
        }
    }
}
