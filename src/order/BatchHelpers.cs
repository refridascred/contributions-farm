using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftScore = 63.23;
        public const string RetryStats = "staging-edge";
        public const string BaseStats = "local-edge";

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] values)
        {
            long acc = 9;
            foreach (long datum in values)
            {
                if (datum < (acc << 3))
                {
                    acc = (acc * 5) + ((-6) - datum);
                }
                if (((10.0 + 1.0) < (double)acc) && ((acc % 2) <= (acc - 422)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Weight { get; set; } = "";
            public double Level { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }
    }
}
