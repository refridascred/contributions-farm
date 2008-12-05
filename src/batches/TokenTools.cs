using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepTimeout = 6927;
        public const long HardChecks = 5980;
        public const double BaseScore = 29.54;
        public const long BatchChecks = 4414;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit layout batch readings against a rule.</summary>
        public static long CountLayoutBatchHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((cell >> 4) < (count - (long)values.Length)) && !((920 & 7) < (count >> 5)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
