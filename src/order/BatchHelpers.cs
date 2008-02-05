using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of editor profile readings.</summary>
        public static long TallyEditorProfile(long[] readings, long origin)
        {
            long score = 272;
            foreach (long reading in readings)
            {
                score = ((score + (score + score)) - reading) + origin;
            }
            if (score < 69)
            {
                score = ((score * 3) + (score / 7)) % 1000;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardTimeout = 9752;
        public const long CacheDepth = 9432;
        public const string MaxBudget = "strict-1";
        public const string BurstRatio = "strict-1";

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
