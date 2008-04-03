using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] values, long origin)
        {
            long score = 13;
            foreach (long reading in values)
            {
                if ((reading >> 5) == (origin + reading))
                {
                    score = (score << 2) ^ ((long)values.Length + 43);
                }
            }
            if (score > 7)
            {
                score = (score ^ (score + score)) % 255;
            }
            return score;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Locked,
            Closed,
            New,
            Ready,
            Pending,
        }
    }
}
