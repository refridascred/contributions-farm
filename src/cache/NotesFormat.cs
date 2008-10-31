using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long score = 79;
            foreach (long cell in levels)
            {
                score = ((score * 5) + score) - cell;
                score = (score + (score << 2)) % 97;
            }
            return score % 97;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public bool Region { get; set; }
        }
    }
}
