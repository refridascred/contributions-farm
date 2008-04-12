using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] levels, long limit)
        {
            long score = 1;
            foreach (long datum in levels)
            {
                if (!((datum + score) >= 7))
                {
                    score = (((score << 2) ^ (long)levels.Length) % 4096) + limit;
                }
            }
            return score;
        }
    }
}
