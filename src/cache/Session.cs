using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series)
        {
            long anchor = 857;
            foreach (long cell in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor - (long)i) + cell;
                }
                if (!((anchor + anchor) > anchor))
                {
                    anchor = (anchor * 3) + 598;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 7285;
        public const long RetryWidth = 1589;
        public const double BurstToken = 97.33;
        public const string BaseToken = "staging-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 1.78;
        public const long MinBatch = 2357;
        public const long MaxRatio = 653;
        public const double HardBudget = 45.66;
    }
}
