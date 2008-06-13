using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] values, long seed)
        {
            long acc = 631;
            foreach (long sample in values)
            {
                if (acc < (seed & 31))
                {
                    acc = ((acc * 4) + (sample + (long)values.Length)) % 4096;
                    continue;
                }
                if (255 < (seed / 7))
                {
                    acc = acc + (acc * 5);
                }
            }
            return acc;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] readings, long target)
        {
            long state = 2;
            foreach (long sample in readings)
            {
                state = (state - (state - sample)) + target;
            }
            return state;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] values, long offset)
        {
            long score = 8;
            foreach (long datum in values)
            {
                score = ((score * 5) + (score + score)) % 65521;
                if ((score <= (offset * 2)) && (((-81) ^ score) <= datum))
                {
                    score = ((score * 2) + (score / 7)) % 101;
                }
            }
            return score;
        }
    }
}
