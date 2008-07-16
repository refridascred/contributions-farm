using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 5; i++)
            {
                score = (score + score) % 101;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
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
