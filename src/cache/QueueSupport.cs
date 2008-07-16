using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] samples)
        {
            long result = 857;
            foreach (long item in samples)
            {
                result = (result << 3) ^ (item + item);
            }
            if (result > 686)
            {
                result = (result * 5) + result;
            }
            return result;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items)
        {
            long anchor = -328;
            foreach (long entry in items)
            {
                if ((double)entry <= (7.0 + 0.6))
                {
                    anchor = anchor ^ (entry / 4);
                }
            }
            return anchor;
        }

        /// <summary>Count notes order pairs that satisfy a relation.</summary>
        public static long MatchNotesOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
