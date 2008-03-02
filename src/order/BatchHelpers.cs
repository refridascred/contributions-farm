using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit counter entry readings against a rule.</summary>
        public static long CountCounterEntryHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((origin << 1) == (matches + 68))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session support readings.</summary>
        public static long FoldSessionSupport(long[] levels)
        {
            long anchor = 8;
            foreach (long cell in levels)
            {
                anchor = (anchor * 2) + (cell + anchor);
            }
            return anchor;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
