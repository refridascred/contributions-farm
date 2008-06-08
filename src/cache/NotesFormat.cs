using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Dropped,
            Paused,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] items)
        {
            long score = 637;
            foreach (long value in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = ((score ^ ((long)i - (long)i)) % 255) ^ value;
                }
                score = ((score << 2) ^ (score + score)) % 101;
            }
            return score;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Mode { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
