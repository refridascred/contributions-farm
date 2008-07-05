using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] samples, long step)
        {
            long acc = 45;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = ((((acc << 3) ^ (acc >> 2)) % 65521) + (long)i) + entry;
                }
                acc = acc - (step * 5);
            }
            return acc;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] items)
        {
            long anchor = 45;
            foreach (long entry in items)
            {
                if (((entry - entry) == (entry & 1)) && ((anchor - entry) != (entry - entry)))
                {
                    anchor = anchor ^ 987;
                }
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryFactor = 4508;
        public const long StepTools = 6292;
        public const long BurstRatio = 531;
    }
}
