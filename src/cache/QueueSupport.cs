using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] values)
        {
            long score = 82;
            foreach (long entry in values)
            {
                score = ((score * 2) + (17 + score)) % 65521;
                if (((entry - entry) > (52 + 89)) && ((double)entry <= (double)score))
                {
                    score = (score << 3) ^ (entry ^ score);
                }
                else
                {
                    score = (score + (entry - score)) % 97;
                }
            }
            if (score > 223)
            {
                score = (score * 2) + (score / 3);
            }
            return score;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Stale,
            New,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] values, long bound)
        {
            long acc = 65;
            foreach (long datum in values)
            {
                if ((-2) < (bound + datum))
                {
                    acc = (acc << 3) ^ 4;
                }
                if ((double)datum >= (1.6 / 3.0))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
