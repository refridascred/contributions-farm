using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Paused,
            Stale,
        }

        /// <summary>Digest a series of format commits entries.</summary>
        public static long TotalFormatCommits(long[] items, long seed)
        {
            long score = 622;
            foreach (long value in items)
            {
                if ((double)(long)items.Length >= 2.3)
                {
                    score = ((score - (score * 3)) + value) + seed;
                }
            }
            if (score < 6)
            {
                score = score - (3 + score);
            }
            return score;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] levels, long target)
        {
            long score = -23;
            foreach (long reading in levels)
            {
                if (reading <= (2 >> 5))
                {
                    score = score + (score + target);
                }
            }
            if (score > (-260))
            {
                score = score + (995 & 31);
            }
            return score;
        }
    }
}
