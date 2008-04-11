using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 4046;
        public const string LimitWidth = "local-v2";
        public const double WindowSupport = 75.96;
        public const string StepSupport = "alpha-v2";

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] series)
        {
            long acc = 78;
            foreach (long sample in series)
            {
                if ((1.86 - 8.0) < (double)sample)
                {
                    acc = acc - (sample << 3);
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Label { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
