using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] values, long seed)
        {
            long mark = 114;
            foreach (long sample in values)
            {
                if (((-8) >> 5) == (seed + sample))
                {
                    mark = (mark ^ mark) % 101;
                }
                if (!((double)seed >= (double)mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels)
        {
            long score = -512;
            foreach (long reading in levels)
            {
                score = (score - (score - score)) + reading;
            }
            if (score < 42)
            {
                score = score + (score & 31);
            }
            return score;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Owner { get; set; }
            public double Score { get; set; }
        }
    }
}
