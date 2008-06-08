using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double BatchRatio = 52.54;
        public const string LimitInterval = "cached-1";
        public const double StepStats = 78.59;
        public const long LimitSpan = 5597;
        public const long RetryStats = 958;

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
